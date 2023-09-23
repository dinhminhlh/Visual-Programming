using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class MainForm : Form
    {
        private List<LichDangKy> lichDangKyList;

        public MainForm()
        {
            InitializeComponent();
            lichDangKyList = new List<LichDangKy>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Đưa ra các lựa chọn cho ComboBox
            cmbCaSuDung.Items.Add("Ca 1");
            cmbCaSuDung.Items.Add("Ca 2");
            cmbCaSuDung.Items.Add("Ca 3");
            cmbCaSuDung.Items.Add("Ca 4");
            cmbCaSuDung.Items.Add("Ca 5");

            cmbMucDich.Items.Add("Dạy bù");
            cmbMucDich.Items.Add("Sinh hoạt lớp");
            cmbMucDich.Items.Add("Hướng dẫn sinh viên NCKH");

            // Cài đặt DataGridView
            dataGridViewLichDangKy.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu và nhập số ở đây

            // Tạo một đối tượng LichDangKy từ thông tin người dùng
            LichDangKy lichMoi = new LichDangKy
            {
                NgaySuDung = txtNgaySuDung.Text,
                CaSuDung = cmbCaSuDung.SelectedItem.ToString(),
                MucDichSuDung = cmbMucDich.SelectedItem.ToString(),
                NguoiDangKy = txtNguoiDangKy.Text,
                MaCanBo = txtMaCanBo.Text,
                SoDienThoai = txtSoDienThoai.Text
            };

            // Thêm đối tượng LichDangKy vào danh sách
            lichDangKyList.Add(lichMoi);

            // Cập nhật DataGridView
            dataGridViewLichDangKy.DataSource = null;
            dataGridViewLichDangKy.DataSource = lichDangKyList;

            // Xóa trắng ô nhập liệu
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtNgaySuDung.Clear();
            cmbCaSuDung.SelectedIndex = -1;
            cmbMucDich.SelectedIndex = -1;
            txtNguoiDangKy.Clear();
            txtMaCanBo.Clear();
            txtSoDienThoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sửa lịch đăng ký đã chọn trong DataGridView
            if (dataGridViewLichDangKy.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLichDangKy.SelectedRows[0].Index;

                // Kiểm tra ràng buộc dữ liệu và nhập số ở đây

                // Cập nhật thông tin lịch đăng ký
                lichDangKyList[selectedIndex].NgaySuDung = txtNgaySuDung.Text;
                lichDangKyList[selectedIndex].CaSuDung = cmbCaSuDung.SelectedItem.ToString();
                lichDangKyList[selectedIndex].MucDichSuDung = cmbMucDich.SelectedItem.ToString();
                lichDangKyList[selectedIndex].NguoiDangKy = txtNguoiDangKy.Text;
                lichDangKyList[selectedIndex].MaCanBo = txtMaCanBo.Text;
                lichDangKyList[selectedIndex].SoDienThoai = txtSoDienThoai.Text;

                // Cập nhật DataGridView
                dataGridViewLichDangKy.DataSource = null;
                dataGridViewLichDangKy.DataSource = lichDangKyList;

                // Xóa trắng ô nhập liệu
                ClearInputFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa lịch đăng ký đã chọn trong DataGridView
            if (dataGridViewLichDangKy.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLichDangKy.SelectedRows[0].Index;
                lichDangKyList.RemoveAt(selectedIndex);

                // Cập nhật DataGridView
                dataGridViewLichDangKy.DataSource = null;
                dataGridViewLichDangKy.DataSource = lichDangKyList;

                // Xóa trắng ô nhập liệu
                ClearInputFields();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Xóa trắng ô nhập liệu
            ClearInputFields();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }
    }
}
