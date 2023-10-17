using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestDataBase
{
    class ProcessDataBase
    {
        SqlConnection con;
        string constring;

        public ProcessDataBase()
        {
            constring = "";
            con = new SqlConnection(constring);
        }

        public void KetNoi()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void DongKetNoi()
        {
            if(con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            con.Dispose();
        }

        public DataTable DocBang(string sql)
        {
            DataTable tb = new DataTable();
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public void CapNhat(string sql)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DongKetNoi();
            cmd.Dispose();
        }
    }
}
