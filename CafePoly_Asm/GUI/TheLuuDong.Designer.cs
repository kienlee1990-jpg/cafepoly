namespace GUI
{
    partial class TheLuuDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLuuDong));
            btnTimKiem = new Button();
            dtgvData2 = new DataGridView();
            txtChuSoHuu = new TextBox();
            txtMaThe = new TextBox();
            label3 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            label2 = new Label();
            cboTrangthai = new ComboBox();
            cboTimKiem = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvData2).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(69, 91);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(122, 34);
            btnTimKiem.TabIndex = 39;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtgvData2
            // 
            dtgvData2.BackgroundColor = SystemColors.GradientActiveCaption;
            dtgvData2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData2.Location = new Point(6, 168);
            dtgvData2.Name = "dtgvData2";
            dtgvData2.RowHeadersWidth = 51;
            dtgvData2.Size = new Size(383, 298);
            dtgvData2.TabIndex = 36;
            dtgvData2.CellDoubleClick += dtgvData2_CellDoubleClick;
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.BackColor = SystemColors.GradientActiveCaption;
            txtChuSoHuu.Location = new Point(119, 68);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(271, 27);
            txtChuSoHuu.TabIndex = 34;
            // 
            // txtMaThe
            // 
            txtMaThe.BackColor = SystemColors.GradientActiveCaption;
            txtMaThe.Location = new Point(118, 26);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.Size = new Size(271, 27);
            txtMaThe.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 75);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 32;
            label3.Text = "Chủ Sở Hữu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã Thẻ";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 40;
            label2.Text = "Trạng Thái";
            // 
            // cboTrangthai
            // 
            cboTrangthai.BackColor = SystemColors.GradientActiveCaption;
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Items.AddRange(new object[] { "Trống", "Đang sử dụng" });
            cboTrangthai.Location = new Point(118, 110);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(271, 28);
            cboTrangthai.TabIndex = 41;
            // 
            // cboTimKiem
            // 
            cboTimKiem.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "Trống", "Đang sử dụng" });
            cboTimKiem.Location = new Point(47, 44);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(161, 28);
            cboTimKiem.TabIndex = 42;
            cboTimKiem.Text = "Trạng thái thẻ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dtgvData2);
            groupBox1.Controls.Add(txtMaThe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboTrangthai);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtChuSoHuu);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(606, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 483);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboTimKiem);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Location = new Point(255, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 131);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 10);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 43;
            label4.Text = "TÌM KIẾM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // TheLuuDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "TheLuuDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thẻ Lưu Động";
            Load += TheLuuDong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvData2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private DataGridView dtgvData2;
        private TextBox txtChuSoHuu;
        private TextBox txtMaThe;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
        private Label label2;
        private ComboBox cboTrangthai;
        private ComboBox cboTimKiem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}