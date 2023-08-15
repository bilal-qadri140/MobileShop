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
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();
        }
        Function fn = new Function();
        String query;
        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string cellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                        //Console.WriteLine("Cell Value: " + cellValue);
                        int.TryParse(cellValue, out int bid);
                        
                        string query = "SELECT * FROM NewRecord WHERE id = '"+bid+"'";
                        // Modify fn.getDataWithParameterizedQuery to use parameterized queries.
                        DataSet ds = fn.getData(query);
                        lblCompany.Text = ds.Tables[0].Rows[0][0].ToString();
                        lblModel.Text = ds.Tables[0].Rows[0][1].ToString();
                        lblRam.Text = ds.Tables[0].Rows[0][2].ToString();
                        lblMemory.Text = ds.Tables[0].Rows[0][3].ToString();
                        lblRCamera.Text = ds.Tables[0].Rows[0][4].ToString();
                        lblFCamera.Text = ds.Tables[0].Rows[0][5].ToString();
                        lblFingerprint.Text = ds.Tables[0].Rows[0][6].ToString();
                        lblPrice.Text = ds.Tables[0].Rows[0][7].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

              

        }

        private void UC_Stock_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM NewRecord";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
