namespace Quanly
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySuDung = new System.Windows.Forms.DateTimePicker();
            this.cmbCaSuDung = new System.Windows.Forms.CheckedListBox();
            this.cmbMucDich = new System.Windows.Forms.ComboBox();
            this.txtNguoiDangKy = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaCanBo = new System.Windows.Forms.TextBox();
            this.dataGridViewLichDangKy = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca sử dụng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mục đích sử dụng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã cán bộ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // txtNgaySuDung
            // 
            this.txtNgaySuDung.Location = new System.Drawing.Point(233, 41);
            this.txtNgaySuDung.Name = "txtNgaySuDung";
            this.txtNgaySuDung.Size = new System.Drawing.Size(216, 26);
            this.txtNgaySuDung.TabIndex = 6;
            // 
            // cmbCaSuDung
            // 
            this.cmbCaSuDung.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbCaSuDung.FormattingEnabled = true;
            this.cmbCaSuDung.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4",
            "Ca 5"});
            this.cmbCaSuDung.Location = new System.Drawing.Point(608, 47);
            this.cmbCaSuDung.Name = "cmbCaSuDung";
            this.cmbCaSuDung.Size = new System.Drawing.Size(71, 119);
            this.cmbCaSuDung.TabIndex = 7;
            this.cmbCaSuDung.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cmbMucDich
            // 
            this.cmbMucDich.FormattingEnabled = true;
            this.cmbMucDich.Items.AddRange(new object[] {
            "Dạy bù",
            "Sinh hoạt lớp",
            "Hướng dẫn sinh viên NCKH"});
            this.cmbMucDich.Location = new System.Drawing.Point(233, 86);
            this.cmbMucDich.Name = "cmbMucDich";
            this.cmbMucDich.Size = new System.Drawing.Size(216, 28);
            this.cmbMucDich.TabIndex = 8;
            this.cmbMucDich.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNguoiDangKy
            // 
            this.txtNguoiDangKy.Location = new System.Drawing.Point(233, 131);
            this.txtNguoiDangKy.Name = "txtNguoiDangKy";
            this.txtNguoiDangKy.Size = new System.Drawing.Size(200, 26);
            this.txtNguoiDangKy.TabIndex = 9;
            this.txtNguoiDangKy.TextChanged += new System.EventHandler(this.txtNguoiDangKy_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(233, 215);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 26);
            this.txtSoDienThoai.TabIndex = 10;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // txtMaCanBo
            // 
            this.txtMaCanBo.Location = new System.Drawing.Point(233, 173);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.Size = new System.Drawing.Size(200, 26);
            this.txtMaCanBo.TabIndex = 11;
            this.txtMaCanBo.TextChanged += new System.EventHandler(this.txtMaCanBo_TextChanged);
            // 
            // dataGridViewLichDangKy
            // 
            this.dataGridViewLichDangKy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewLichDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichDangKy.Location = new System.Drawing.Point(36, 256);
            this.dataGridViewLichDangKy.Name = "dataGridViewLichDangKy";
            this.dataGridViewLichDangKy.RowHeadersWidth = 62;
            this.dataGridViewLichDangKy.RowTemplate.Height = 28;
            this.dataGridViewLichDangKy.Size = new System.Drawing.Size(1070, 254);
            this.dataGridViewLichDangKy.TabIndex = 12;
            this.dataGridViewLichDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLichDangKy_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 57);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(701, 543);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 57);
            this.button6.TabIndex = 18;
            this.button6.Text = "Thêm mới";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(932, 543);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 57);
            this.button7.TabIndex = 19;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(479, 543);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 57);
            this.button8.TabIndex = 20;
            this.button8.Text = "Xóa";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 612);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewLichDangKy);
            this.Controls.Add(this.txtMaCanBo);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtNguoiDangKy);
            this.Controls.Add(this.cmbMucDich);
            this.Controls.Add(this.cmbCaSuDung);
            this.Controls.Add(this.txtNgaySuDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtNgaySuDung;
        private System.Windows.Forms.CheckedListBox cmbCaSuDung;
        private System.Windows.Forms.ComboBox cmbMucDich;
        private System.Windows.Forms.TextBox txtNguoiDangKy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMaCanBo;
        private System.Windows.Forms.DataGridView dataGridViewLichDangKy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

