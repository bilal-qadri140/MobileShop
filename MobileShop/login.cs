using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobileShop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        

        Function fn = new Function();
        String query;
        public String password;
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword fp = new forgotPassword();
            fp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    String sql = "SELECT * FROM ADMIN WHERE aName = '" + txtUsername.Text + "'";
                    DataSet dataSet = fn.getData(sql);
                    if (txtUsername.Text != dataSet.Tables[0].Rows[0][0].ToString())
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {

                        query = "SELECT * FROM ADMIN WHERE aName = '" + txtUsername.Text + "'";
                        DataSet ds = fn.getData(query);


                        //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                        if (txtPassword.Text != ds.Tables[0].Rows[0][1].ToString())
                        {
                            MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            //txtUsername.Clear();
                        }
                        else
                        {
                            mainform mf = new mainform();
                            password = ds.Tables[0].Rows[0][1].ToString();
                            
                            mf.setValue(password);
                            mf.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception)
            {
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Clear();
            }


        }
        private void btnCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup su = new signup();
            su.Show();
            this.Hide();
        }
    }
}
