namespace GUI
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            label4 = new Label();
            label2 = new Label();
            txtMaKH = new TextBox();
            txtTen = new TextBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            dtgvData4 = new DataGridView();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            label3 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            txtTKMHD = new TextBox();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox5 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox6 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgvData4).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 92);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 56;
            label4.Text = "MaxKH :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 158);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 55;
            label2.Text = "Tên KH :";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(142, 84);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(227, 30);
            txtMaKH.TabIndex = 54;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(142, 151);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(227, 30);
            txtTen.TabIndex = 53;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(81, 113);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 27);
            btnTimKiem.TabIndex = 52;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(4, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 30);
            txtTimKiem.TabIndex = 51;
            txtTimKiem.Text = "Theo tên, điện thoại";
            txtTimKiem.MouseHover += txtTimKiem_MouseHover;
            // 
            // dtgvData4
            // 
            dtgvData4.BackgroundColor = Color.White;
            dtgvData4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData4.Location = new Point(755, 221);
            dtgvData4.Name = "dtgvData4";
            dtgvData4.RowHeadersWidth = 51;
            dtgvData4.Size = new Size(530, 372);
            dtgvData4.TabIndex = 49;
            dtgvData4.CellDoubleClick += dtgvData4_CellDoubleClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(142, 283);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(227, 30);
            txtDiaChi.TabIndex = 48;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(142, 221);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(227, 30);
            txtSDT.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 290);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 46;
            label3.Text = "Địa chỉ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 228);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 45;
            label1.Text = "SDT :";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThem, menuSua, menuXoa, menuXoaTrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1325, 28);
            menuStrip1.TabIndex = 44;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(514, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 90);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhóm khách hàng";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả các nhóm" });
            comboBox1.Location = new Point(21, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 31);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtTKMHD);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1082, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(203, 146);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtTKMHD
            // 
            txtTKMHD.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTKMHD.Location = new Point(4, 65);
            txtTKMHD.Name = "txtTKMHD";
            txtTKMHD.Size = new Size(193, 30);
            txtTKMHD.TabIndex = 52;
            txtTKMHD.Text = "Mã hóa đơn";
            txtTKMHD.MouseHover += textBox1_MouseHover;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(514, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(203, 97);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ngày tạo";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tất cả các nhóm" });
            comboBox2.Location = new Point(44, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 31);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Toàn thời gian";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(44, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 30);
            textBox2.TabIndex = 3;
            textBox2.Text = "Lựa chọn khác";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 67);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(radioButton7);
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton4);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(514, 337);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(203, 107);
            groupBox4.TabIndex = 59;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giới tính";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton7.Location = new Point(21, 77);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(54, 27);
            radioButton7.TabIndex = 2;
            radioButton7.TabStop = true;
            radioButton7.Text = "Nữ";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(21, 29);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 27);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tất cả";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(21, 53);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 27);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nam";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(radioButton5);
            groupBox5.Controls.Add(radioButton8);
            groupBox5.Controls.Add(radioButton6);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(514, 477);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(203, 116);
            groupBox5.TabIndex = 60;
            groupBox5.TabStop = false;
            groupBox5.Text = "Trạng thái";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.Location = new Point(21, 29);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(77, 27);
            radioButton5.TabIndex = 3;
            radioButton5.TabStop = true;
            radioButton5.Text = "Tất cả";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton8.Location = new Point(21, 53);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(157, 27);
            radioButton8.TabIndex = 2;
            radioButton8.TabStop = true;
            radioButton8.Text = "Đang hoạt động";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton6.Location = new Point(21, 77);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(169, 27);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Ngừng hoạt động";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(txtMaKH);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(txtTen);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(txtSDT);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(txtDiaChi);
            groupBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(45, 79);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(400, 514);
            groupBox6.TabIndex = 58;
            groupBox6.TabStop = false;
            groupBox6.Text = "KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgvData4);
            Controls.Add(menuStrip1);
            Name = "KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvData4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private TextBox txtMaKH;
        private TextBox txtTen;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dtgvData4;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private TextBox txtTKMHD;
        private GroupBox groupBox3;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private RadioButton radioButton7;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox5;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton8;
        private GroupBox groupBox6;
    }
}