namespace GUI
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            dtgvData = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThem, menuSua, menuXoa, menuXoaTrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1325, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuThem
            // 
            menuThem.Image = (Image)resources.GetObject("menuThem.Image");
            menuThem.Name = "menuThem";
            menuThem.Size = new Size(80, 24);
            menuThem.Text = "Thêm";
            menuThem.Click += menuThem_Click;
            // 
            // menuSua
            // 
            menuSua.Image = (Image)resources.GetObject("menuSua.Image");
            menuSua.Name = "menuSua";
            menuSua.Size = new Size(68, 24);
            menuSua.Text = "Sửa";
            menuSua.Click += menuSua_Click;
            // 
            // menuXoa
            // 
            menuXoa.Image = (Image)resources.GetObject("menuXoa.Image");
            menuXoa.Name = "menuXoa";
            menuXoa.Size = new Size(69, 24);
            menuXoa.Text = "Xóa";
            menuXoa.Click += menuXoa_Click;
            // 
            // menuXoaTrang
            // 
            menuXoaTrang.Image = (Image)resources.GetObject("menuXoaTrang.Image");
            menuXoaTrang.Name = "menuXoaTrang";
            menuXoaTrang.Size = new Size(108, 24);
            menuXoaTrang.Text = "Xóa trắng";
            menuXoaTrang.Click += menuXoaTrang_Click;
            // 
            // menuThoat
            // 
            menuThoat.Image = (Image)resources.GetObject("menuThoat.Image");
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(81, 24);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(516, 49);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(516, 132);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(516, 96);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(903, 93);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(903, 53);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(631, 46);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(175, 27);
            txtMaNV.TabIndex = 6;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(631, 89);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(175, 27);
            txtTenNV.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(1006, 89);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(175, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(1006, 46);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(175, 27);
            txtMatKhau.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(631, 129);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(550, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // dtgvData
            // 
            dtgvData.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData.Location = new Point(514, 162);
            dtgvData.Name = "dtgvData";
            dtgvData.RowHeadersWidth = 51;
            dtgvData.Size = new Size(667, 362);
            dtgvData.TabIndex = 11;
            dtgvData.CellDoubleClick += dtgvData_CellDoubleClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(835, 549);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(225, 27);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.Text = "Tìm kiếm theo tên nhân viên";
            txtTimKiem.Click += txtTimKiem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(1066, 549);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 27);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 70);
            label7.Name = "label7";
            label7.Size = new Size(284, 31);
            label7.TabIndex = 15;
            label7.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(29, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 98);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(25, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 98);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi nhánh làm việc";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chi nhánh trung tâm" });
            comboBox1.Location = new Point(21, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(25, 382);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(274, 98);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phòng ban";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 20;
            textBox1.Text = "Chọn phòng ban";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(textBox2);
            groupBox4.Location = new Point(25, 507);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(274, 98);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức danh";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(21, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 20;
            textBox2.Text = "Chọn chức danh";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Đang làm việc";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(40, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Đã nghỉ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dtgvData);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSDT);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục nhân viên";
            Load += NhanVien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtDiaChi;
        private DataGridView dtgvData;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}