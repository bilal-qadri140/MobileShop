using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        Function fn = new Function();
        login li = new login();
        String query;

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            li.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String password = txtPassword.Text;
            String newPassword = txtConPassword.Text;
            if (name != "" && password != "" && newPassword != "")
            {
                if (password == newPassword)
                {
                    try
                    {
                        query = "UPDATE ADMIN SET password = '"+password+"' WHERE aName = '"+name+"'";
                        fn.setData(query);
                        txtName.Clear();
                        txtPassword.Clear();
                        txtConPassword.Clear();
                        MessageBox.Show("Password updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        li.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        // Handle exceptions here
                        MessageBox.Show("This admin is already registered ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password does't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtName_Validation(object sender, EventArgs e)
        {
            String name = txtName.Text;
            try
            {
                query = "SELECT DISTINCT * FROM ADMIN WHERE aName = '" + name + "'";

                DataSet ds = fn.getData(query);
                //MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
                if (name != ds.Tables[0].Rows[0][0].ToString())
                {
                    MessageBox.Show("This username is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Clear();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("This username is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
            }
        }
    }
}
