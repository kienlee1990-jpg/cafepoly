namespace GUI
{
    partial class DoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoUong));
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label6 = new Label();
            dtgvData3 = new DataGridView();
            txtDonGia = new TextBox();
            txtMaLoai = new TextBox();
            label3 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            txtTenDU = new TextBox();
            txtMaDU = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtHinhAnh = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvData3).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(50, 78);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 38);
            btnTimKiem.TabIndex = 39;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(18, 42);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(179, 27);
            txtTimKiem.TabIndex = 38;
            txtTimKiem.Text = "Theo mã, tên hàng";
            txtTimKiem.MouseClick += txtTimKiem_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 13);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 37;
            label6.Text = "Tìm kiếm";
            // 
            // dtgvData3
            // 
            dtgvData3.BackgroundColor = Color.White;
            dtgvData3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData3.Location = new Point(379, 171);
            dtgvData3.Name = "dtgvData3";
            dtgvData3.RowHeadersWidth = 51;
            dtgvData3.Size = new Size(847, 409);
            dtgvData3.TabIndex = 36;
            dtgvData3.CellDoubleClick += dtgvData3_CellDoubleClick;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(537, 36);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(120, 27);
            txtDonGia.TabIndex = 34;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(350, 36);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(128, 27);
            txtMaLoai.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 10);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 32;
            label3.Text = "Đơn giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã loại";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThem, menuSua, menuXoa, menuXoaTrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1325, 28);
            menuStrip1.TabIndex = 30;
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
            // txtTenDU
            // 
            txtTenDU.Location = new Point(182, 36);
            txtTenDU.Name = "txtTenDU";
            txtTenDU.Size = new Size(112, 27);
            txtTenDU.TabIndex = 40;
            // 
            // txtMaDU
            // 
            txtMaDU.Location = new Point(6, 36);
            txtMaDU.Name = "txtMaDU";
            txtMaDU.Size = new Size(100, 27);
            txtMaDU.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 10);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 42;
            label2.Text = "Tên Đồ Uống";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 10);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 43;
            label4.Text = "Mã Đồ Uống";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(704, 36);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(113, 27);
            txtHinhAnh.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(729, 10);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 45;
            label5.Text = "Hình ảnh";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtMaDU);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenDU);
            groupBox1.Controls.Add(txtMaLoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(379, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 79);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(79, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 138);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(78, 267);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(218, 149);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(50, 107);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 24);
            checkBox3.TabIndex = 43;
            checkBox3.Text = "Khác";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(50, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 24);
            checkBox2.TabIndex = 42;
            checkBox2.Text = "Đồ uống";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 24);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Đồ ăn";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 14);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 40;
            label7.Text = "Loại thực đơn";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(79, 431);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(218, 149);
            groupBox4.TabIndex = 49;
            groupBox4.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(49, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 43;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tất cả";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(49, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(153, 24);
            radioButton2.TabIndex = 42;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ngừng kinh doanh";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 24);
            radioButton1.TabIndex = 41;
            radioButton1.TabStop = true;
            radioButton1.Text = "Đang kinh doanh";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 14);
            label8.Name = "label8";
            label8.Size = new Size(148, 23);
            label8.TabIndex = 40;
            label8.Text = "Lựa chọn hiển thị";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 45);
            label9.Name = "label9";
            label9.Size = new Size(358, 41);
            label9.TabIndex = 44;
            label9.Text = "DANH MỤC HÀNG HÓA";
            // 
            // DoUong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgvData3);
            Controls.Add(menuStrip1);
            Name = "DoUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đồ uống";
            Load += DoUong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvData3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label6;
        private DataGridView dtgvData3;
        private TextBox txtDonGia;
        private TextBox txtMaLoai;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
        private TextBox txtTenDU;
        private TextBox txtMaDU;
        private Label label2;
        private Label label4;
        private TextBox txtHinhAnh;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label9;
    }
}