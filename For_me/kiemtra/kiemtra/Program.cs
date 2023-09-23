using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyLichDangKyPhong
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
            // ??a ra c�c l?a ch?n cho ComboBox
            cmbCaSuDung.Items.Add("Ca 1");
            cmbCaSuDung.Items.Add("Ca 2");
            cmbCaSuDung.Items.Add("Ca 3");
            cmbCaSuDung.Items.Add("Ca 4");
            cmbCaSuDung.Items.Add("Ca 5");

            cmbMucDich.Items.Add("D?y b�");
            cmbMucDich.Items.Add("Sinh ho?t l?p");
            cmbMucDich.Items.Add("H??ng d?n sinh vi�n NCKH");

            // C�i ??t DataGridView
            dataGridViewLichDangKy.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Ki?m tra r�ng bu?c d? li?u v� nh?p s? ? ?�y
            if (string.IsNullOrWhiteSpace(txtNgaySuDung.Text) ||
                cmbCaSuDung.SelectedItem == null ||
                cmbMucDich.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtNguoiDangKy.Text) ||
                string.IsNullOrWhiteSpace(txtMaCanBo.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui l�ng ?i?n ??y ?? th�ng tin v� ki?m tra r�ng bu?c d? li?u.", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // T?o m?t ??i t??ng LichDangKy t? th�ng tin ng??i d�ng
            LichDangKy lichMoi = new LichDangKy
            {
                NgaySuDung = txtNgaySuDung.Text,
                CaSuDung = cmbCaSuDung.SelectedItem.ToString(),
                MucDichSuDung = cmbMucDich.SelectedItem.ToString(),
                NguoiDangKy = txtNguoiDangKy.Text,
                MaCanBo = txtMaCanBo.Text,
                SoDienThoai = txtSoDienThoai.Text
            };

            // Th�m ??i t??ng LichDangKy v�o danh s�ch
            lichDangKyList.Add(lichMoi);

            // C?p nh?t DataGridView
            dataGridViewLichDangKy.DataSource = null;
            dataGridViewLichDangKy.DataSource = lichDangKyList;

            // X�a tr?ng � nh?p li?u
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

        private void dataGridViewLichDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hi?n th? th�ng tin chi ti?t khi ng??i d�ng ch?n m?t d�ng trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewLichDangKy.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewLichDangKy.Rows[e.RowIndex];
                txtNgaySuDung.Text = selectedRow.Cells["colNgaySuDung"].Value.ToString();
                cmbCaSuDung.SelectedItem = selectedRow.Cells["colCaSuDung"].Value.ToString();
                cmbMucDich.SelectedItem = selectedRow.Cells["colMucDichSuDung"].Value.ToString();
                txtNguoiDangKy.Text = selectedRow.Cells["colNguoiDangKy"].Value.ToString();
                txtMaCanBo.Text = selectedRow.Cells["colMaCanBo"].Value.ToString();
                txtSoDienThoai.Text = selectedRow.Cells["colSoDienThoai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // S?a l?ch ??ng k� ?� ch?n trong DataGridView
            if (dataGridViewLichDangKy.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLichDangKy.SelectedRows[0].Index;

                // Ki?m tra r�ng bu?c d? li?u v� nh?p s? ? ?�y
                if (string.IsNullOrWhiteSpace(txtNgaySuDung.Text) ||
                    cmbCaSuDung.SelectedItem == null ||
                    cmbMucDich.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtNguoiDangKy.Text) ||
                    string.IsNullOrWhiteSpace(txtMaCanBo.Text) ||
                    string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui l�ng ?i?n ??y ?? th�ng tin v� ki?m tra r�ng bu?c d? li?u.", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // C?p nh?t th�ng tin l?ch ??ng k�
                lichDangKyList[selectedIndex].NgaySuDung = txtNgaySuDung.Text;
                lichDangKyList[selectedIndex].CaSuDung = cmbCaSuDung.SelectedItem.ToString();
                lichDangKyList[selectedIndex].MucDichSuDung = cmbMucDich.SelectedItem.ToString();
                lichDangKyList[selectedIndex].NguoiDangKy = txtNguoiDangKy.Text;
                lichDangKyList[selectedIndex].MaCanBo = txtMaCanBo.Text;
                lichDangKyList[selectedIndex].SoDienThoai = txtSoDienThoai.Text;

                // C?p nh?t DataGridView
                dataGridViewLichDangKy.DataSource = null;
                dataGridViewLichDangKy.DataSource = lichDangKyList;

                // X�a tr?ng � nh?p li?u
                ClearInputFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // X�a l?ch ??ng k� ?� ch?n trong DataGridView
            if (dataGridViewLichDangKy.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLichDangKy.SelectedRows[0].Index;
                lichDangKyList.RemoveAt(selectedIndex);

                // C?p nh?t DataGridView
                dataGridViewLichDangKy.DataSource = null;
                dataGridViewLichDangKy.DataSource = lichDangKyList;

                // X�a tr?ng � nh?p li?u
                ClearInputFields();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // X�a tr?ng � nh?p li?u
            ClearInputFields();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Tho�t ?ng d?ng
            Application.Exit();
        }
    }
}
