using Guna.UI2.WinForms;
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

namespace MobileShop.AllUserControl
{
    public partial class UC_DeleteCustomer : UserControl
    {
        public UC_DeleteCustomer()
        {
            InitializeComponent();
        }
        Function fn = new Function();
        String query;

        private void UC_DeleteCustomer_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM NewRecord";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM NewRecord WHERE company LIKE '%" + txtInput.Text + "%' or model LIKE '%" + txtInput.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string cellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //Console.WriteLine("Cell Value: " + cellValue);
                int.TryParse(cellValue, out int bid);
                string query = "DELETE FROM NewRecord WHERE id = '" + bid + "'";

                if (MessageBox.Show("Deleting record of id " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    fn.getData(query);
                    MessageBox.Show("Data deleted successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You cancelled the operations.", "Back", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
