using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.AllUserControl
{
    public partial class UC_CustomerRecord : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_CustomerRecord()
        {
            InitializeComponent();
        }
        bool flag;
        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                flag = false;
                lblToChange.Text = "Enter Customer Name";
                enableDisable(true,true);
                txtInput.Clear();
            }
            else if(txtSearch.SelectedIndex == 1)
            {
                flag = true;
                lblToChange.Text = "Enter IMEI";
                enableDisable(true, true);
                txtInput.Clear();
            }
            
        }

        

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                query = "SELECT * FROM Customer WHERE name LIKE '%" + txtInput.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
               
                //Console.WriteLine("Output is: "+txtInput);
            }
            else
            {
                query = "SELECT * FROM Customer WHERE imei LIKE '%" + txtInput.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                
            }
        }

        private void UC_CustomerRecord_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Customer";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            enableDisable(false, false);
        }

        public void enableDisable(Boolean lbl, Boolean txt)
        {
            lblToChange.Enabled = lbl;
            txtInput.Enabled = txt;
        }
    }
}
