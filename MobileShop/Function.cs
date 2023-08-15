using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\BILAL QADRI\\OneDrive\\Documents\\MobileShop.mdf\";Integrated Security=True;Connect Timeout=30";
            return conn;
        }
        // for Extracting data from database
        public DataSet getData(String  sql)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;

        }
        //for insertion, updation, deletion
        public void setData(String query)
        {
            SqlConnection conn =  getConnection ();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public SqlDataReader getForCombo(String quer)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(quer,con);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}
