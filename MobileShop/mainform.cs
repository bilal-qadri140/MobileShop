using MobileShop.AllUserControl;
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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        UC_CustomerRecord cr = new UC_CustomerRecord();

        String value;
        public void setValue(String Password)
        {
            this.value = Password;
        }

        private void uC_AddNewRecord2_Load(object sender, EventArgs e)
        {

        }
        

        private void mainform_Load_1(object sender, EventArgs e)
        {
            uC_Wellcome1.Visible = true;
            enableDisable(false,false,false);
            uC_DeleteCustomer1.Visible = false;
            uC_CustomerRecord1.Visible = false;
            uC_AddNewRecord2.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            login li = new login();
            li.Hide();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_DeleteCustomer1.Visible = false;
            uC_AddNewRecord2.Visible = false;
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
            uC_Stock1.Visible = false;
            uC_CustomerRecord1.Visible = false;
            enableDisable(false, false, false);

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            uC_DeleteCustomer1.Visible = false;
            enableDisable(false, false, false);
            uC_Customer1.Visible = false;
            uC_AddNewRecord2.Visible = true;
            uC_AddNewRecord2.BringToFront();
        }


        private void btnStocks_Click(object sender, EventArgs e)
        {
            uC_DeleteCustomer1.Visible = false;
            enableDisable(false, false, false);
            uC_AddNewRecord2.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnCustomerRecord_Click(object sender, EventArgs e)
        {
            uC_DeleteCustomer1.Visible = false;
            enableDisable(false, false, false);
            uC_AddNewRecord2.Visible = false;
            uC_Stock1.Visible = false;
            uC_Customer1.Visible = false;
            uC_CustomerRecord1.Visible = true;
            uC_CustomerRecord1.BringToFront();
            uC_CustomerRecord1.Enabled = true;

            // for responsiveness
            uC_CustomerRecord1.txtSearch.SelectedIndex = -1;
            uC_CustomerRecord1.txtInput.Clear();
            uC_CustomerRecord1.lblToChange.Enabled = false;
            uC_CustomerRecord1.txtInput.Enabled = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            uC_DeleteCustomer1.Visible = false;
            uC_AddNewRecord2.Visible = false;
            uC_Stock1.Visible = false;
            uC_Customer1.Visible = false;
            uC_CustomerRecord1.Visible = true;
            uC_CustomerRecord1.BringToFront();
            enableDisable(true, true, true);
            uC_CustomerRecord1.txtSearch.SelectedIndex = -1;
            uC_CustomerRecord1.txtInput.Clear();
            uC_CustomerRecord1.Enabled = false;

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void enableDisable(Boolean txt1, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txt1;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
            txtPassword.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            uC_CustomerRecord1.Enabled = true;
            enableDisable(false,false,false);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //login lp = new login();
            //String pas = lp.password;

            //MessageBox.Show(value);
            if (txtPassword.Text == value)
            {
                uC_DeleteCustomer1.Visible = true;
                uC_DeleteCustomer1.BringToFront();
            }
            else
            {
                txtPassword.Clear() ;
            }
        }

        private void uC_DeleteCustomer1_Load(object sender, EventArgs e)
        {

        }
    }
}
