using System;
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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        Function fn = new Function(); // function for connections
        String query;
        login li = new login(); // login form reference

        forgotPassword fp = new forgotPassword();
        
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            li.Show(); // show login form and hide signup form
            this.Hide();
        }
        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fp.Show(); // show forgot password form and hide signup form
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String password = txtPassword.Text;
            String conPassword = txtConPassword.Text;
            if (name != "" && password != "" && conPassword != "")
            {
                if (password == conPassword)
                {
                    try
                    {
                        query = "INSERT INTO ADMIN VALUES ('" + name + "','" + password + "')";
                        fn.setData(query);
                        MessageBox.Show("Admin Account Created Successfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPassword.Clear();
                        txtConPassword.Clear();
                        
                        li.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
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
    }
}
