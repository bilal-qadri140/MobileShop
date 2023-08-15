using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }
        Function fn = new Function();
        String query;

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader reader = fn.getForCombo(query);
            while (reader.Read())
            {
                for(int i = 0; i<reader.FieldCount; i++)
                {
                    combo.Items.Add(reader.GetString(i));   
                }
            }
        }
        public void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "SELECT DISTINCT company FROM NewRecord";
            setComboBox(query, txtCompany);
        }
        public void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cName = txtCompany.Text;
            query = "SELECT  model FROM NewRecord WHERE company = '"+cName+"'";
            setComboBox(query, txtModel);
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string model = txtModel.Text;

                // Assuming fn is a class that handles database operations
                string query = "SELECT * FROM NewRecord WHERE model = '"+model+"'";
                DataSet ds = fn.getData(query);

                lblRam.Text = ds.Tables[0].Rows[0][2].ToString();
                lblMemory.Text = ds.Tables[0].Rows[0][3].ToString(); 
                lblRCamera.Text = ds.Tables[0].Rows[0][4].ToString();
                lblFCamera.Text = ds.Tables[0].Rows[0][5].ToString();
                lblFingerprint.Text = ds.Tables[0].Rows[0][6].ToString();
                lblPrice.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtContact.Text != "" &&
               txtEmail.Text != "" && txtGender.Text != "" &&
               txtAddress.Text != "" && txtCompany.Text != "" &&
               txtModel.Text != "" && txtIMEI.Text != "")
                {
                    String name = txtName.Text;
                    String contact = txtContact.Text;
                    String email = txtEmail.Text;
                    String gender = txtGender.Text;
                    String address = txtAddress.Text;
                    String company = txtCompany.Text;
                    String model = txtModel.Text;
                    String imei = txtIMEI.Text;

                    query = "INSERT INTO Customer(name,cNo,gender,email,address,company,model,imei) VALUES ('" + name + "','" + contact + "','" + gender + "','" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                    fn.setData(query);

                    //clear the form
                    txtName.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    txtGender.Items.Clear();
                    txtIMEI.Clear();
                    txtAddress.Clear();
                    txtCompany.Items.Clear();
                    txtModel.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill all the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
