namespace GUI
{
    partial class ManHinhChinh
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            nhậpTồnKhoHàngHóaToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            loạiĐồUốngToolStripMenuItem = new ToolStripMenuItem();
            đồUốngToolStripMenuItem = new ToolStripMenuItem();
            thẻLưuĐộngToolStripMenuItem = new ToolStripMenuItem();
            nguyênLiệuToolStripMenuItem = new ToolStripMenuItem();
            côngThứcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuTheoNgàyToolStripMenuItem = new ToolStripMenuItem();
            xemLịchSửHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnTheDaChon = new Button();
            dtgvHoaDon = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnXoaCTDU = new Button();
            pictureBox1 = new PictureBox();
            txtTenNVBH = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnThanhToan = new Button();
            label7 = new Label();
            lblTongTien = new Label();
            lsvThe = new ListView();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            rdoYes = new RadioButton();
            rdoNo = new RadioButton();
            rdoAll = new RadioButton();
            nudSL = new NumericUpDown();
            btnThemMoi = new Button();
            cboDoUong = new TextBox();
            lsvOD = new ListView();
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            btnLoad = new Button();
            btnGiaoDo = new Button();
            txtTKKH = new TextBox();
            btnTKKH = new Button();
            btnThemKH = new Button();
            txtMaKH = new TextBox();
            dtgvKH = new DataGridView();
            txtMaHD = new TextBox();
            txtMaDUXoa = new TextBox();
            txtTenDUXoa = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvKH).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, thốngKêToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1325, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênTàiKhoảnToolStripMenuItem, thôngTinCáNhânToolStripMenuItem, nhậpTồnKhoHàngHóaToolStripMenuItem });
            hệThốngToolStripMenuItem.Image = (Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(108, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // nhânViênTàiKhoảnToolStripMenuItem
            // 
            nhânViênTàiKhoảnToolStripMenuItem.Name = "nhânViênTàiKhoảnToolStripMenuItem";
            nhânViênTàiKhoảnToolStripMenuItem.Size = new Size(248, 26);
            nhânViênTàiKhoảnToolStripMenuItem.Text = "Nhân viên - Tài khoản";
            nhânViênTàiKhoảnToolStripMenuItem.Click += nhânViênTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(248, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Đổi mật khẩu";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // nhậpTồnKhoHàngHóaToolStripMenuItem
            // 
            nhậpTồnKhoHàngHóaToolStripMenuItem.Name = "nhậpTồnKhoHàngHóaToolStripMenuItem";
            nhậpTồnKhoHàngHóaToolStripMenuItem.Size = new Size(248, 26);
            nhậpTồnKhoHàngHóaToolStripMenuItem.Text = "Nhập tồn kho hàng hóa";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loạiĐồUốngToolStripMenuItem, đồUốngToolStripMenuItem, thẻLưuĐộngToolStripMenuItem, nguyênLiệuToolStripMenuItem, côngThứcToolStripMenuItem });
            danhMụcToolStripMenuItem.Image = (Image)resources.GetObject("danhMụcToolStripMenuItem.Image");
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(110, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // loạiĐồUốngToolStripMenuItem
            // 
            loạiĐồUốngToolStripMenuItem.Name = "loạiĐồUốngToolStripMenuItem";
            loạiĐồUốngToolStripMenuItem.Size = new Size(180, 26);
            loạiĐồUốngToolStripMenuItem.Text = "Loại đồ uống";
            loạiĐồUốngToolStripMenuItem.Click += loạiĐồUốngToolStripMenuItem_Click;
            // 
            // đồUốngToolStripMenuItem
            // 
            đồUốngToolStripMenuItem.Name = "đồUốngToolStripMenuItem";
            đồUốngToolStripMenuItem.Size = new Size(180, 26);
            đồUốngToolStripMenuItem.Text = "Đồ uống";
            đồUốngToolStripMenuItem.Click += đồUốngToolStripMenuItem_Click;
            // 
            // thẻLưuĐộngToolStripMenuItem
            // 
            thẻLưuĐộngToolStripMenuItem.Name = "thẻLưuĐộngToolStripMenuItem";
            thẻLưuĐộngToolStripMenuItem.Size = new Size(180, 26);
            thẻLưuĐộngToolStripMenuItem.Text = "Thẻ lưu động";
            thẻLưuĐộngToolStripMenuItem.Click += thẻLưuĐộngToolStripMenuItem_Click;
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            nguyênLiệuToolStripMenuItem.Size = new Size(180, 26);
            nguyênLiệuToolStripMenuItem.Text = "Nguyên liệu";
            // 
            // côngThứcToolStripMenuItem
            // 
            côngThứcToolStripMenuItem.Name = "côngThứcToolStripMenuItem";
            côngThứcToolStripMenuItem.Size = new Size(180, 26);
            côngThứcToolStripMenuItem.Text = "Công thức";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image");
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(179, 24);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuTheoNgàyToolStripMenuItem, xemLịchSửHóaĐơnToolStripMenuItem });
            thốngKêToolStripMenuItem.Image = (Image)resources.GetObject("thốngKêToolStripMenuItem.Image");
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(104, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêDoanhThuTheoNgàyToolStripMenuItem
            // 
            thốngKêDoanhThuTheoNgàyToolStripMenuItem.Name = "thốngKêDoanhThuTheoNgàyToolStripMenuItem";
            thốngKêDoanhThuTheoNgàyToolStripMenuItem.Size = new Size(227, 26);
            thốngKêDoanhThuTheoNgàyToolStripMenuItem.Text = "Thống kê doanh thu";
            thốngKêDoanhThuTheoNgàyToolStripMenuItem.Click += thốngKêDoanhThuTheoNgàyToolStripMenuItem_Click;
            // 
            // xemLịchSửHóaĐơnToolStripMenuItem
            // 
            xemLịchSửHóaĐơnToolStripMenuItem.Name = "xemLịchSửHóaĐơnToolStripMenuItem";
            xemLịchSửHóaĐơnToolStripMenuItem.Size = new Size(227, 26);
            xemLịchSửHóaĐơnToolStripMenuItem.Text = "Xem lịch sử hóa đơn";
            xemLịchSửHóaĐơnToolStripMenuItem.Click += xemLịchSửHóaĐơnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(113, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = (Image)resources.GetObject("thoátToolStripMenuItem.Image");
            thoátToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(81, 24);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "THẺ ĐANG CHỌN";
            // 
            // btnTheDaChon
            // 
            btnTheDaChon.BackColor = Color.FromArgb(0, 0, 192);
            btnTheDaChon.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTheDaChon.ForeColor = SystemColors.ButtonHighlight;
            btnTheDaChon.Location = new Point(172, 45);
            btnTheDaChon.Name = "btnTheDaChon";
            btnTheDaChon.Size = new Size(125, 37);
            btnTheDaChon.TabIndex = 3;
            btnTheDaChon.Text = "Chưa chon thẻ";
            btnTheDaChon.UseVisualStyleBackColor = false;
            // 
            // dtgvHoaDon
            // 
            dtgvHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDon.Location = new Point(788, 189);
            dtgvHoaDon.Name = "dtgvHoaDon";
            dtgvHoaDon.RowHeadersWidth = 51;
            dtgvHoaDon.Size = new Size(537, 357);
            dtgvHoaDon.TabIndex = 5;
            dtgvHoaDon.CellClick += dtgvHoaDon_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(406, 50);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 6;
            label2.Text = "SỐ LƯỢNG :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(874, 116);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(383, 92);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 8;
            label4.Text = "Tìm theo tên đồ uống ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(0, 0, 192);
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(698, 84);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 39);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(546, 89);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(149, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(874, 82);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 14;
            label5.Text = "Nhân viên bán hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(894, 34);
            label6.Name = "label6";
            label6.Size = new Size(263, 38);
            label6.TabIndex = 15;
            label6.Text = "Thông tin hóa đơn";
            // 
            // btnXoaCTDU
            // 
            btnXoaCTDU.BackColor = Color.FromArgb(0, 0, 192);
            btnXoaCTDU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaCTDU.ForeColor = SystemColors.ButtonHighlight;
            btnXoaCTDU.Location = new Point(788, 150);
            btnXoaCTDU.Name = "btnXoaCTDU";
            btnXoaCTDU.Size = new Size(177, 39);
            btnXoaCTDU.TabIndex = 16;
            btnXoaCTDU.Text = "Xóa đồ uống";
            btnXoaCTDU.UseVisualStyleBackColor = false;
            btnXoaCTDU.Click += btnXoaCTDU_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1208, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtTenNVBH
            // 
            txtTenNVBH.Location = new Point(1021, 75);
            txtTenNVBH.Name = "txtTenNVBH";
            txtTenNVBH.ReadOnly = true;
            txtTenNVBH.Size = new Size(181, 27);
            txtTenNVBH.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1021, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(0, 0, 192);
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnThanhToan.Location = new Point(1139, 561);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(117, 36);
            btnThanhToan.TabIndex = 20;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(874, 574);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 22;
            label7.Text = "TỔNG :";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.White;
            lblTongTien.Location = new Point(969, 574);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(62, 23);
            lblTongTien.TabIndex = 23;
            lblTongTien.Text = "0 VND";
            // 
            // lsvThe
            // 
            lsvThe.BackColor = SystemColors.ButtonHighlight;
            lsvThe.BorderStyle = BorderStyle.None;
            lsvThe.Location = new Point(0, 144);
            lsvThe.Name = "lsvThe";
            lsvThe.Size = new Size(307, 485);
            lsvThe.TabIndex = 24;
            lsvThe.UseCompatibleStateImageBehavior = false;
            lsvThe.Click += lsvThe_Click;
            lsvThe.DoubleClick += lsvThe_DoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ec");
            imageList1.Images.SetKeyName(1, "z6651076808774_067b353e76ead1ecc61fbc2aac43f676.jpg");
            imageList1.Images.SetKeyName(2, "z6651076815159_91a3f66b43d87507c1123577fc3a9080.jpg");
            imageList1.Images.SetKeyName(3, "cps");
            imageList1.Images.SetKeyName(4, "bx");
            imageList1.Images.SetKeyName(5, "tstc");
            imageList1.Images.SetKeyName(6, "man");
            imageList1.Images.SetKeyName(7, "bhn");
            imageList1.Images.SetKeyName(8, "vina");
            imageList1.Images.SetKeyName(9, "heniken");
            imageList1.Images.SetKeyName(10, "kent");
            imageList1.Images.SetKeyName(11, "milano");
            imageList1.Images.SetKeyName(12, "aperol");
            imageList1.Images.SetKeyName(13, "cubalibre");
            imageList1.Images.SetKeyName(14, "bloodymary");
            imageList1.Images.SetKeyName(15, "ginfizz");
            imageList1.Images.SetKeyName(16, "lemontea");
            imageList1.Images.SetKeyName(17, "peachtea");
            imageList1.Images.SetKeyName(18, "minttea");
            imageList1.Images.SetKeyName(19, "liptonwithmilk");
            imageList1.Images.SetKeyName(20, "lemonjuice");
            imageList1.Images.SetKeyName(21, "aqua");
            imageList1.Images.SetKeyName(22, "dasani");
            imageList1.Images.SetKeyName(23, "lavie");
            imageList1.Images.SetKeyName(24, "bn");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoYes);
            groupBox1.Controls.Add(rdoNo);
            groupBox1.Controls.Add(rdoAll);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(7, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 55);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // rdoYes
            // 
            rdoYes.AutoSize = true;
            rdoYes.ForeColor = Color.White;
            rdoYes.Location = new Point(189, 25);
            rdoYes.Name = "rdoYes";
            rdoYes.Size = new Size(93, 29);
            rdoYes.TabIndex = 2;
            rdoYes.TabStop = true;
            rdoYes.Text = "Thẻ Mở";
            rdoYes.UseVisualStyleBackColor = true;
            rdoYes.CheckedChanged += rdoYes_CheckedChanged;
            // 
            // rdoNo
            // 
            rdoNo.AutoSize = true;
            rdoNo.ForeColor = Color.White;
            rdoNo.Location = new Point(93, 24);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new Size(90, 29);
            rdoNo.TabIndex = 1;
            rdoNo.TabStop = true;
            rdoNo.Text = "Thẻ Tắt";
            rdoNo.UseVisualStyleBackColor = true;
            rdoNo.CheckedChanged += rdoNo_CheckedChanged;
            // 
            // rdoAll
            // 
            rdoAll.AutoSize = true;
            rdoAll.ForeColor = Color.White;
            rdoAll.Location = new Point(6, 24);
            rdoAll.Name = "rdoAll";
            rdoAll.Size = new Size(79, 29);
            rdoAll.TabIndex = 0;
            rdoAll.TabStop = true;
            rdoAll.Text = "Tất cả";
            rdoAll.UseVisualStyleBackColor = true;
            rdoAll.CheckedChanged += rdoAll_CheckedChanged;
            // 
            // nudSL
            // 
            nudSL.Location = new Point(546, 46);
            nudSL.Name = "nudSL";
            nudSL.Size = new Size(75, 27);
            nudSL.TabIndex = 26;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(0, 0, 192);
            btnThemMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.ForeColor = SystemColors.ButtonHighlight;
            btnThemMoi.Location = new Point(658, 39);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(130, 39);
            btnThemMoi.TabIndex = 27;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // cboDoUong
            // 
            cboDoUong.BackColor = Color.White;
            cboDoUong.ForeColor = Color.Black;
            cboDoUong.Location = new Point(313, 118);
            cboDoUong.Name = "cboDoUong";
            cboDoUong.ReadOnly = true;
            cboDoUong.Size = new Size(140, 27);
            cboDoUong.TabIndex = 28;
            cboDoUong.Visible = false;
            // 
            // lsvOD
            // 
            lsvOD.Location = new Point(309, 144);
            lsvOD.Name = "lsvOD";
            lsvOD.Size = new Size(479, 485);
            lsvOD.TabIndex = 29;
            lsvOD.UseCompatibleStateImageBehavior = false;
            lsvOD.Click += lsvOD_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "TheTrong.jpg");
            imageList2.Images.SetKeyName(1, "TheHoatDong.jpg");
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "TheTrong.jpg");
            imageList3.Images.SetKeyName(1, "TheHoatDong.jpg");
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoad.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(313, 107);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(33, 38);
            btnLoad.TabIndex = 30;
            btnLoad.TextAlign = ContentAlignment.MiddleRight;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnGiaoDo
            // 
            btnGiaoDo.BackColor = Color.FromArgb(0, 0, 192);
            btnGiaoDo.BackgroundImageLayout = ImageLayout.Zoom;
            btnGiaoDo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiaoDo.ForeColor = SystemColors.ButtonHighlight;
            btnGiaoDo.Image = (Image)resources.GetObject("btnGiaoDo.Image");
            btnGiaoDo.ImageAlign = ContentAlignment.MiddleRight;
            btnGiaoDo.Location = new Point(200, 382);
            btnGiaoDo.Name = "btnGiaoDo";
            btnGiaoDo.Size = new Size(107, 43);
            btnGiaoDo.TabIndex = 31;
            btnGiaoDo.Text = "Giao Đồ";
            btnGiaoDo.TextAlign = ContentAlignment.MiddleLeft;
            btnGiaoDo.UseVisualStyleBackColor = false;
            btnGiaoDo.Click += btnGiaoDo_Click;
            // 
            // txtTKKH
            // 
            txtTKKH.Location = new Point(1021, 150);
            txtTKKH.Name = "txtTKKH";
            txtTKKH.Size = new Size(157, 27);
            txtTKKH.TabIndex = 32;
            // 
            // btnTKKH
            // 
            btnTKKH.BackColor = Color.FromArgb(255, 192, 128);
            btnTKKH.BackgroundImageLayout = ImageLayout.Zoom;
            btnTKKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTKKH.ForeColor = Color.White;
            btnTKKH.Image = (Image)resources.GetObject("btnTKKH.Image");
            btnTKKH.Location = new Point(1184, 144);
            btnTKKH.Name = "btnTKKH";
            btnTKKH.Size = new Size(40, 39);
            btnTKKH.TabIndex = 33;
            btnTKKH.TextAlign = ContentAlignment.MiddleRight;
            btnTKKH.UseVisualStyleBackColor = false;
            btnTKKH.Click += btnTKKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.FromArgb(255, 192, 128);
            btnThemKH.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKH.ForeColor = Color.White;
            btnThemKH.Image = (Image)resources.GetObject("btnThemKH.Image");
            btnThemKH.Location = new Point(1221, 144);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(50, 39);
            btnThemKH.TabIndex = 34;
            btnThemKH.TextAlign = ContentAlignment.MiddleRight;
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(1277, 150);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(48, 27);
            txtMaKH.TabIndex = 35;
            txtMaKH.Visible = false;
            // 
            // dtgvKH
            // 
            dtgvKH.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKH.Location = new Point(788, 189);
            dtgvKH.Name = "dtgvKH";
            dtgvKH.RowHeadersWidth = 51;
            dtgvKH.Size = new Size(537, 357);
            dtgvKH.TabIndex = 36;
            dtgvKH.Visible = false;
            dtgvKH.CellClick += dtgvKH_CellClick;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(546, 116);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(48, 27);
            txtMaHD.TabIndex = 37;
            txtMaHD.Visible = false;
            // 
            // txtMaDUXoa
            // 
            txtMaDUXoa.Location = new Point(827, 544);
            txtMaDUXoa.Name = "txtMaDUXoa";
            txtMaDUXoa.Size = new Size(48, 27);
            txtMaDUXoa.TabIndex = 39;
            txtMaDUXoa.Visible = false;
            // 
            // txtTenDUXoa
            // 
            txtTenDUXoa.Location = new Point(983, 544);
            txtTenDUXoa.Name = "txtTenDUXoa";
            txtTenDUXoa.Size = new Size(48, 27);
            txtTenDUXoa.TabIndex = 40;
            txtTenDUXoa.Visible = false;
            // 
            // ManHinhChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(txtTenDUXoa);
            Controls.Add(txtMaDUXoa);
            Controls.Add(txtMaHD);
            Controls.Add(dtgvKH);
            Controls.Add(txtMaKH);
            Controls.Add(btnThemKH);
            Controls.Add(btnTKKH);
            Controls.Add(txtTKKH);
            Controls.Add(btnGiaoDo);
            Controls.Add(btnLoad);
            Controls.Add(lsvOD);
            Controls.Add(cboDoUong);
            Controls.Add(btnThemMoi);
            Controls.Add(nudSL);
            Controls.Add(groupBox1);
            Controls.Add(lsvThe);
            Controls.Add(lblTongTien);
            Controls.Add(label7);
            Controls.Add(btnThanhToan);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTenNVBH);
            Controls.Add(pictureBox1);
            Controls.Add(btnXoaCTDU);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtgvHoaDon);
            Controls.Add(btnTheDaChon);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ManHinhChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Màn hình chính";
            Load += ManHinhChinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Label label1;
        private Button btnTheDaChon;
        private DataGridView dtgvHoaDon;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label5;
        private Label label6;
        private Button btnXoaCTDU;
        private PictureBox pictureBox1;
        private TextBox txtTenNVBH;
        private DateTimePicker dateTimePicker1;
        private Button btnThanhToan;
        private Label label7;
        private Label lblTongTien;
        private ToolStripMenuItem nhânViênTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem nhậpTồnKhoHàngHóaToolStripMenuItem;
        private ToolStripMenuItem loạiĐồUốngToolStripMenuItem;
        private ToolStripMenuItem đồUốngToolStripMenuItem;
        private ToolStripMenuItem thẻLưuĐộngToolStripMenuItem;
        private ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private ToolStripMenuItem côngThứcToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuTheoNgàyToolStripMenuItem;
        private ToolStripMenuItem xemLịchSửHóaĐơnToolStripMenuItem;
        private ListView lsvThe;
        private ImageList imageList1;
        private GroupBox groupBox1;
        private RadioButton rdoYes;
        private RadioButton rdoNo;
        private RadioButton rdoAll;
        private NumericUpDown nudSL;
        private Button btnThemMoi;
        private TextBox cboDoUong;
        private ListView lsvOD;
        private ImageList imageList2;
        private ImageList imageList3;
        private Button btnLoad;
        private Button btnGiaoDo;
        private TextBox txtTKKH;
        private Button btnTKKH;
        private Button btnThemKH;
        private TextBox txtMaKH;
        private DataGridView dtgvKH;
        private TextBox txtMaHD;
        private TextBox txtMaDUXoa;
        private TextBox txtTenDUXoa;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}