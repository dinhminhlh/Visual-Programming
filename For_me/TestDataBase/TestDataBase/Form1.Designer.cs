namespace TestDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtMaCL = new TextBox();
            txtTenCL = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvChatLieu = new DataGridView();
            MaCL = new DataGridViewTextBoxColumn();
            TenCL = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnThemMoi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(267, 35);
            label1.Name = "label1";
            label1.Size = new Size(624, 57);
            label1.TabIndex = 0;
            label1.Text = "Danh sách các chất liệu";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaCL);
            groupBox1.Controls.Add(txtTenCL);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 165);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMaCL
            // 
            txtMaCL.Location = new Point(192, 43);
            txtMaCL.Name = "txtMaCL";
            txtMaCL.Size = new Size(556, 31);
            txtMaCL.TabIndex = 3;
            // 
            // txtTenCL
            // 
            txtTenCL.Location = new Point(192, 100);
            txtTenCL.Name = "txtTenCL";
            txtTenCL.Size = new Size(556, 31);
            txtTenCL.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 103);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên chất liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 46);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 3;
            label2.Text = "Mã chất liệu";
            // 
            // dgvChatLieu
            // 
            dgvChatLieu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChatLieu.Columns.AddRange(new DataGridViewColumn[] { MaCL, TenCL });
            dgvChatLieu.Location = new Point(36, 323);
            dgvChatLieu.Name = "dgvChatLieu";
            dgvChatLieu.RowHeadersWidth = 62;
            dgvChatLieu.RowTemplate.Height = 33;
            dgvChatLieu.Size = new Size(807, 285);
            dgvChatLieu.TabIndex = 5;
            // 
            // MaCL
            // 
            MaCL.HeaderText = " Mã chất liệu";
            MaCL.MinimumWidth = 8;
            MaCL.Name = "MaCL";
            MaCL.Width = 350;
            // 
            // TenCL
            // 
            TenCL.HeaderText = "Tên chất liệu";
            TenCL.MinimumWidth = 8;
            TenCL.Name = "TenCL";
            TenCL.Width = 400;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThemMoi);
            groupBox2.Location = new Point(903, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 478);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(43, 37);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(112, 34);
            btnThemMoi.TabIndex = 6;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1162, 645);
            Controls.Add(groupBox2);
            Controls.Add(dgvChatLieu);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "frmChatLieu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaCL;
        private TextBox txtTenCL;
        private Label label3;
        private Label label2;
        private DataGridView dgvChatLieu;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnSua;
        private Button btnThemMoi;
        private DataGridViewTextBoxColumn MaCL;
        private DataGridViewTextBoxColumn TenCL;
    }
}