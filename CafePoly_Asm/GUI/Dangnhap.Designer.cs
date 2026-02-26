namespace GUI
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            chkNhoMatKhau = new CheckBox();
            groupBox1 = new GroupBox();
            rdoThuNgan = new RadioButton();
            rdoQLy = new RadioButton();
            btnAn = new Button();
            btnHien = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(236, 37);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 552);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(94, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 2;
            label1.Text = "LOGIN INTO ACCOUNT";
            // 
            // txtDangNhap
            // 
            txtDangNhap.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDangNhap.Location = new Point(94, 126);
            txtDangNhap.Margin = new Padding(4, 3, 4, 3);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.PlaceholderText = "Mã Nhân Viên";
            txtDangNhap.Size = new Size(307, 30);
            txtDangNhap.TabIndex = 4;
            txtDangNhap.Click += txtDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(94, 173);
            txtMatKhau.Margin = new Padding(4, 3, 4, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "Password";
            txtMatKhau.Size = new Size(307, 30);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.Click += txtMatKhau_Click;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Blue;
            btnDangNhap.FlatAppearance.BorderColor = SystemColors.HighlightText;
            btnDangNhap.FlatAppearance.BorderSize = 2;
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ButtonFace;
            btnDangNhap.Location = new Point(33, 252);
            btnDangNhap.Margin = new Padding(4, 3, 4, 3);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(368, 54);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkNhoMatKhau
            // 
            chkNhoMatKhau.AutoSize = true;
            chkNhoMatKhau.Location = new Point(94, 219);
            chkNhoMatKhau.Name = "chkNhoMatKhau";
            chkNhoMatKhau.Size = new Size(150, 27);
            chkNhoMatKhau.TabIndex = 8;
            chkNhoMatKhau.Text = "Remember me";
            chkNhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(rdoThuNgan);
            groupBox1.Controls.Add(rdoQLy);
            groupBox1.Controls.Add(btnAn);
            groupBox1.Controls.Add(btnHien);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkNhoMatKhau);
            groupBox1.Controls.Add(txtDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Location = new Point(669, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 552);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rdoThuNgan
            // 
            rdoThuNgan.AutoSize = true;
            rdoThuNgan.Checked = true;
            rdoThuNgan.Location = new Point(138, 323);
            rdoThuNgan.Name = "rdoThuNgan";
            rdoThuNgan.Size = new Size(106, 27);
            rdoThuNgan.TabIndex = 1;
            rdoThuNgan.TabStop = true;
            rdoThuNgan.Text = "Thu ngân";
            rdoThuNgan.UseVisualStyleBackColor = true;
            // 
            // rdoQLy
            // 
            rdoQLy.AutoSize = true;
            rdoQLy.Location = new Point(33, 323);
            rdoQLy.Name = "rdoQLy";
            rdoQLy.Size = new Size(92, 27);
            rdoQLy.TabIndex = 0;
            rdoQLy.Text = "Quản lý";
            rdoQLy.UseVisualStyleBackColor = true;
            // 
            // btnAn
            // 
            btnAn.BackgroundImage = (Image)resources.GetObject("btnAn.BackgroundImage");
            btnAn.BackgroundImageLayout = ImageLayout.Zoom;
            btnAn.FlatAppearance.BorderColor = Color.White;
            btnAn.FlatStyle = FlatStyle.Flat;
            btnAn.Location = new Point(342, 173);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(50, 26);
            btnAn.TabIndex = 21;
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Visible = false;
            btnAn.Click += btnAn_Click;
            // 
            // btnHien
            // 
            btnHien.BackgroundImage = (Image)resources.GetObject("btnHien.BackgroundImage");
            btnHien.BackgroundImageLayout = ImageLayout.Zoom;
            btnHien.FlatAppearance.BorderColor = Color.White;
            btnHien.FlatStyle = FlatStyle.Flat;
            btnHien.Location = new Point(342, 174);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(50, 26);
            btnHien.TabIndex = 20;
            btnHien.UseVisualStyleBackColor = true;
            btnHien.MouseClick += btnHien_MouseClick;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(227, 474);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(174, 54);
            button7.TabIndex = 19;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(33, 456);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(201, 90);
            button6.TabIndex = 18;
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.AliceBlue;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(33, 173);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(39, 30);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(33, 124);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(39, 32);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 373);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 14;
            label5.Text = "or login with";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(251, 323);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 13;
            label4.Text = "Forget Password?";
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(303, 410);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(119, 44);
            button3.TabIndex = 12;
            button3.Text = "Twitter";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(160, 410);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(120, 44);
            button2.TabIndex = 11;
            button2.Text = "Google";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(16, 410);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(127, 44);
            button1.TabIndex = 10;
            button1.Text = "Facebook";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(274, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 51);
            label2.TabIndex = 18;
            label2.Text = "CÀ PHÊ POLY";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1325, 629);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private CheckBox chkNhoMatKhau;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Button button5;
        private Button button4;
        private Label label2;
        private Button button6;
        private Button button7;
        private Button btnHien;
        private Button btnAn;
        private RadioButton rdoThuNgan;
        private RadioButton rdoQLy;
    }
}