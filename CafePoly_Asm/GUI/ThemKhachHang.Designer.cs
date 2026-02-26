namespace GUI
{
    partial class ThemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhachHang));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnChonAnh = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            txtGhiChu = new TextBox();
            txtNhom = new TextBox();
            label13 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            txtXa = new TextBox();
            label10 = new Label();
            txtHuyen = new TextBox();
            label9 = new Label();
            txtTinh = new TextBox();
            label8 = new Label();
            dtpNgaySInh = new DateTimePicker();
            label7 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            label5 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            txtMaKH = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(37, 244);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(113, 38);
            btnChonAnh.TabIndex = 2;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtNhom);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtXa);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtHuyen);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTinh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgaySInh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(190, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 496);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(587, 411);
            button1.Name = "button1";
            button1.Size = new Size(113, 50);
            button1.TabIndex = 4;
            button1.Text = "Lưu";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(706, 411);
            button2.Name = "button2";
            button2.Size = new Size(141, 50);
            button2.TabIndex = 5;
            button2.Text = "Bỏ qua";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(490, 326);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(357, 27);
            txtGhiChu.TabIndex = 27;
            txtGhiChu.Text = "Ghi chú";
            txtGhiChu.MouseClick += txtGhiChu_MouseClick;
            // 
            // txtNhom
            // 
            txtNhom.Location = new Point(587, 262);
            txtNhom.Name = "txtNhom";
            txtNhom.Size = new Size(260, 27);
            txtNhom.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(490, 267);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 25;
            label13.Text = "Nhóm";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(587, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(490, 202);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 23;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(490, 128);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 22;
            label11.Text = "Giới tính";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Location = new Point(587, 108);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 51);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(131, 18);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 24);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nữ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 18);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nam";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtXa
            // 
            txtXa.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtXa.Location = new Point(160, 453);
            txtXa.Name = "txtXa";
            txtXa.Size = new Size(260, 27);
            txtXa.TabIndex = 21;
            txtXa.Text = "Phường / Xã";
            txtXa.MouseClick += txtXa_MouseClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 453);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 20;
            label10.Text = "Phường / Xã";
            // 
            // txtHuyen
            // 
            txtHuyen.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtHuyen.Location = new Point(160, 404);
            txtHuyen.Name = "txtHuyen";
            txtHuyen.Size = new Size(260, 27);
            txtHuyen.TabIndex = 19;
            txtHuyen.Text = "Quận / Huyện";
            txtHuyen.MouseClick += txtHuyen_MouseClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 411);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 18;
            label9.Text = "Quận / Huyện";
            // 
            // txtTinh
            // 
            txtTinh.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTinh.Location = new Point(160, 347);
            txtTinh.Name = "txtTinh";
            txtTinh.Size = new Size(260, 27);
            txtTinh.TabIndex = 17;
            txtTinh.Text = "Tỉnh / Thành phố";
            txtTinh.MouseClick += txtTinh_MouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 354);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 16;
            label8.Text = "Tỉnh / Thành phố";
            // 
            // dtpNgaySInh
            // 
            dtpNgaySInh.Location = new Point(160, 238);
            dtpNgaySInh.Name = "dtpNgaySInh";
            dtpNgaySInh.Size = new Size(260, 27);
            dtpNgaySInh.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 243);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 14;
            label7.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(160, 290);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(260, 27);
            txtDiaChi.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 297);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 12;
            label6.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(160, 185);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(260, 27);
            txtSDT.TabIndex = 11;
            txtSDT.Text = "Ví dụ :  0912345678";
            txtSDT.MouseClick += txtSDT_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 188);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 10;
            label5.Text = "Điện thoại";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(160, 132);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(260, 27);
            txtTen.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 135);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 8;
            label4.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(160, 78);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(260, 27);
            txtMaKH.TabIndex = 7;
            txtMaKH.Text = "Mã mặc đinh";
            txtMaKH.MouseClick += txtMaKH_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 85);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 6;
            label3.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(175, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 51);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(131, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Công ty";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cá nhân";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Loại khách";
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 577);
            Controls.Add(groupBox1);
            Controls.Add(btnChonAnh);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ThemKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnChonAnh;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private Label label7;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtMaKH;
        private Label label3;
        private Label label12;
        private Label label11;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox txtXa;
        private Label label10;
        private TextBox txtHuyen;
        private Label label9;
        private TextBox txtTinh;
        private Label label8;
        private DateTimePicker dtpNgaySInh;
        private TextBox txtGhiChu;
        private TextBox txtNhom;
        private Label label13;
        private TextBox txtEmail;
        private Button button1;
        private Button button2;
    }
}