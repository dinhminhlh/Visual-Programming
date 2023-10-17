using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal class ProcessDataBase
    {
        SqlConnection con;
        DataTable tblSinhvien;

        public void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=LE-THI-THUY;Initial Catalog=tblSinhVien;Integrated Security=True";
            con.Open();
        }
        public void Disconnect()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }

    }
}
