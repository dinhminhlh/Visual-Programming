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

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        SqlConnection con;
        DataTable tblSinhvien;
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=LE-THI-THUY;Initial Catalog=tblSinhVien;Integrated Security=True";
            string sql;
            sql = "SELECT * FROM tblSinhVien";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            tblSinhvien = new DataTable();
            MyData.Fill(tblSinhvien);
            DGV1.DataSource = tblSinhvien;
        }

        public void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "UPDATE tblSinhVien SET Hoten='" + txtHoTen.Text +
            "',Ngaysinh='" + txtNgaySinh.Text +
            "',Khoa='" + txtKhoa.Text + "',Lop='" + txtLop.Text +
            "',Diachi='" + txtDiaChi.Text + "' WHERE MaSV='" + txtMaSV.Text + "'";
            RunSQL(sql); //thực hiện lệnh sql
            LoadDataGridView(); //hiển thị lại thông tin lên DataGridView
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaSV FROM tblSinhVien WHERE MaSV=N'" + txtMaSV.Text + "'";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblSinhVien WHERE MaSV='" + txtMaSV.Text + "'";
                RunSQL(sql);
                LoadDataGridView();
                //ResetValue();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            string sql;
            //Thực hiện chèn thêm mới
            sql = "INSERT INTO tblSinhVien VALUES ('" + txtMaSV.Text + "','" + txtHoTen.Text + "','" +
            txtNgaySinh.Text + "','" + txtKhoa.Text + "','" + txtLop.Text + "','" + txtDiaChi.Text +
            "')";
            RunSQL(sql);
            LoadDataGridView();
        }
    }
}
