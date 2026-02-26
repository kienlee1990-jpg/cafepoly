namespace GUI
{
    partial class Loaidouong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loaidouong));
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            dtgvData1 = new DataGridView();
            txtDiaChi = new TextBox();
            txtTenLoai = new TextBox();
            txtMaLoai = new TextBox();
            label3 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            menuXoaTrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgvData1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimKiem.Location = new Point(205, 439);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 27);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(186, 403);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(164, 27);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.Text = "Tìm theo tên";
            txtTimKiem.Click += txtTimKiem_Click;
            // 
            // dtgvData1
            // 
            dtgvData1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgvData1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData1.Location = new Point(50, 137);
            dtgvData1.Name = "dtgvData1";
            dtgvData1.RowHeadersWidth = 51;
            dtgvData1.Size = new Size(300, 234);
            dtgvData1.TabIndex = 26;
            dtgvData1.CellDoubleClick += dtgvData1_CellDoubleClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(162, 115);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(0, 27);
            txtDiaChi.TabIndex = 25;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(162, 83);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(175, 27);
            txtTenLoai.TabIndex = 22;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(162, 46);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(175, 27);
            txtMaLoai.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 18;
            label3.Text = "Tên loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 53);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã loại";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThem, menuSua, menuXoa, menuXoaTrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(418, 28);
            menuStrip1.TabIndex = 15;
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
            // Loaidouong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(418, 478);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dtgvData1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Loaidouong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục loại đồ uống";
            Load += Loaidouong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvData1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dtgvData1;
        private TextBox txtDiaChi;
        private TextBox txtTenLoai;
        private TextBox txtMaLoai;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem menuXoa;
        private ToolStripMenuItem menuXoaTrang;
        private ToolStripMenuItem menuThoat;
    }
}