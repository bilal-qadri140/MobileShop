using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop.AllUserControl
{
    public partial class UC_AddNewRecord : UserControl
    {
        public UC_AddNewRecord()
        {
            InitializeComponent();
        }

        Function fn = new Function();
        String query;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCompany.Text) && !string.IsNullOrEmpty(txtModel.Text) 
                    && !string.IsNullOrEmpty(txtRam.Text) && !string.IsNullOrEmpty(txtMemory.Text) 
                    && !string.IsNullOrEmpty(txtRearCamera.Text) && !string.IsNullOrEmpty(txtFrontCamera.Text)
                    && !string.IsNullOrEmpty(txtFingerPrint.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                {
                    string company = txtCompany.Text;
                    string model = txtModel.Text;
                    string ram = txtRam.Text;
                    string memory = txtMemory.Text;
                    string rCamera = txtRearCamera.Text;
                    string fCamera = txtFrontCamera.Text;
                    string fingerprint = txtFingerPrint.Text;

                    if (Int64.TryParse(txtPrice.Text, out Int64 price))
                    {
                        // Use parameterized queries to prevent SQL injection
                        string query = "INSERT INTO NewRecord (company, model, ram, memory, rCamera, fCamera, fingerprint, price) VALUES (@company, @model, @ram, @memory, @rCamera, @fCamera, @fingerprint, @price)";

                        // Create a connection object and command object for the query
                        using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\BILAL QADRI\\OneDrive\\Documents\\MobileShop.mdf\";Integrated Security=True;Connect Timeout=30"))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@company", company);
                            command.Parameters.AddWithValue("@model", model);
                            command.Parameters.AddWithValue("@ram", ram);
                            command.Parameters.AddWithValue("@memory", memory);
                            command.Parameters.AddWithValue("@rCamera", rCamera);
                            command.Parameters.AddWithValue("@fCamera", fCamera);
                            command.Parameters.AddWithValue("@fingerprint", fingerprint);
                            command.Parameters.AddWithValue("@price", price);

                            // Open the connection, execute the query, and then close the connection
                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Price Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtCompany.Clear();
                    txtModel.Clear();
                    txtRam.SelectedIndex = -1;
                    txtMemory.SelectedIndex = -1;
                    txtRearCamera.SelectedIndex = -1; 
                    txtFrontCamera.SelectedIndex = -1; 
                    txtFingerPrint.SelectedIndex = -1;
                    txtPrice.Clear();


                }
                else
                {
                    MessageBox.Show("Please fill all the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.SelectedIndex = -1;
            txtMemory.SelectedIndex = -1;
            txtRearCamera.SelectedIndex = -1;
            txtFrontCamera.SelectedIndex = -1;
            txtFingerPrint.SelectedIndex = -1;
            txtPrice.Clear();
        }
    }
}
