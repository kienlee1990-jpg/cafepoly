namespace GUI
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            label5 = new Label();
            txtTongTien = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtMaHD = new TextBox();
            txtMaThe = new TextBox();
            btnTimKiem = new Button();
            txtTKMaHD = new TextBox();
            label6 = new Label();
            dtgvHD = new DataGridView();
            txtMaKH = new TextBox();
            txtMaNV = new TextBox();
            label3 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            label7 = new Label();
            label8 = new Label();
            txtTrangThai = new TextBox();
            dtpNgayLap = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtTKKH = new TextBox();
            txtTKDU = new TextBox();
            groupBox3 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvHD).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(825, 12);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 60;
            label5.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(815, 41);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(97, 27);
            txtTongTien.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 58;
            label4.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 14);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 57;
            label2.Text = "Mã thẻ";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(27, 39);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(63, 27);
            txtMaHD.TabIndex = 56;
            // 
            // txtMaThe
            // 
            txtMaThe.Location = new Point(142, 39);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.Size = new Size(68, 27);
            txtMaThe.TabIndex = 55;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(35, 237);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(147, 33);
            btnTimKiem.TabIndex = 54;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTKMaHD
            // 
            txtTKMaHD.Location = new Point(18, 75);
            txtTKMaHD.Name = "txtTKMaHD";
            txtTKMaHD.PlaceholderText = "Theo mã HD";
            txtTKMaHD.Size = new Size(211, 27);
            txtTKMaHD.TabIndex = 53;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 23);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 52;
            label6.Text = "Tìm kiếm";
            // 
            // dtgvHD
            // 
            dtgvHD.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHD.Location = new Point(377, 141);
            dtgvHD.Name = "dtgvHD";
            dtgvHD.RowHeadersWidth = 51;
            dtgvHD.Size = new Size(930, 474);
            dtgvHD.TabIndex = 51;
            dtgvHD.CellDoubleClick += dtgvHD_CellDoubleClick;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(365, 39);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(80, 27);
            txtMaKH.TabIndex = 50;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(256, 39);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(72, 27);
            txtMaNV.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 14);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 48;
            label3.Text = "Mã KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 47;
            label1.Text = "Mã NV";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThem, menuSua, menuXoa, menuXoaTrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1325, 28);
            menuStrip1.TabIndex = 46;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 12);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 61;
            label7.Text = "Ngày lập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(685, 12);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 62;
            label8.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(675, 39);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(111, 27);
            txtTrangThai.TabIndex = 63;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(480, 39);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(168, 27);
            dtpNgayLap.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(txtTrangThai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaThe);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Location = new Point(377, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 84);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtTKKH);
            groupBox2.Controls.Add(txtTKDU);
            groupBox2.Controls.Add(txtTKMaHD);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(34, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 302);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            // 
            // txtTKKH
            // 
            txtTKKH.Location = new Point(18, 166);
            txtTKKH.Name = "txtTKKH";
            txtTKKH.PlaceholderText = "Theo mã, tên khách hàng";
            txtTKKH.Size = new Size(211, 27);
            txtTKKH.TabIndex = 57;

            // 
            // txtTKDU
            // 
            txtTKDU.Location = new Point(18, 123);
            txtTKDU.Name = "txtTKDU";
            txtTKDU.PlaceholderText = "Theo mã,  tên đồ uống";
            txtTKDU.Size = new Size(211, 27);
            txtTKDU.TabIndex = 55;

            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(37, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 188);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(32, 129);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(140, 24);
            checkBox3.TabIndex = 61;
            checkBox3.Text = "Chưa thanh toán";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(32, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(154, 24);
            checkBox2.TabIndex = 60;
            checkBox2.Text = "Đã TT chờ giao đồ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 59;
            checkBox1.Text = "Hoàn thành";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 23);
            label9.Name = "label9";
            label9.Size = new Size(163, 23);
            label9.TabIndex = 58;
            label9.Text = "Trạng thái hóa đơn";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(284, 172);
            button1.Name = "button1";
            button1.Size = new Size(87, 30);
            button1.TabIndex = 68;
            button1.Text = "Load";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1325, 629);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgvHD);
            Controls.Add(menuStrip1);
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += HoaDon_Load;

            ((System.ComponentModel.ISupportInitialize)dtgvHD).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtTongTien;
        private Label label4;
        private Label label2;
        private TextBox txtMaHD;
        private TextBox txtMaThe;
        private Button btnTimKiem;
        private TextBox txtTKMaHD;
        private Label label6;
        private DataGridView dtgvHD;
        private TextBox txtMaKH;
        private TextBox txtMaNV;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
        private Label label7;
        private Label label8;
        private TextBox txtTrangThai;
        private DateTimePicker dtpNgayLap;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTKKH;
        private TextBox txtTKDU;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label9;
        private Button button1;
    }
}