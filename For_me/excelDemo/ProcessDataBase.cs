using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp2;
namespace WindowsFormsApp2
{
    class ProcessDataBase
    {
        string strcon= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\excelDemo\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        public void Connect()
        {
            con = new SqlConnection(strcon);
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void ConnectClose()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
            con.Dispose();
        }
        public DataTable ReadTable(string sql)
        {
            DataTable tb = new DataTable();
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(tb);
            ConnectClose();
            return tb;
        }
        public void UpdateData(string sql)
        {
            Connect();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            cm.Dispose();
        }
    }
}
