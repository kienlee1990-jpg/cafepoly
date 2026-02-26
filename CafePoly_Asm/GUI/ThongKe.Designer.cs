namespace GUI
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            dtpBD = new DateTimePicker();
            lbl1 = new Label();
            lbl2 = new Label();
            btnLoc = new Button();
            dtgvDTN = new DataGridView();
            dtpKT = new DateTimePicker();
            groupBox1 = new GroupBox();
            lblPhanTram = new Label();
            label11 = new Label();
            btnTang = new Button();
            btnGiam = new Button();
            label10 = new Label();
            label9 = new Label();
            lblDTQua = new Label();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            lblDTNay = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblPhanTramKH = new Label();
            label8 = new Label();
            btnTang2 = new Button();
            btnGiam2 = new Button();
            label12 = new Label();
            label13 = new Label();
            lblSLKHQua = new Label();
            label15 = new Label();
            button4 = new Button();
            label16 = new Label();
            label17 = new Label();
            lblSLKHNay = new Label();
            label19 = new Label();
            cboNgay = new ComboBox();
            dtgvNV = new DataGridView();
            label4 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvDTN).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpBD
            // 
            dtpBD.Location = new Point(591, 349);
            dtpBD.Name = "dtpBD";
            dtpBD.Size = new Size(251, 27);
            dtpBD.TabIndex = 0;
            dtpBD.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(516, 354);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(69, 20);
            lbl1.TabIndex = 1;
            lbl1.Text = "Từ ngày :";
            lbl1.Visible = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(516, 399);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "Đến ngày :";
            lbl2.Visible = false;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.Brown;
            btnLoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.ForeColor = SystemColors.ControlLightLight;
            btnLoc.Location = new Point(604, 462);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(126, 40);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtgvDTN
            // 
            dtgvDTN.BackgroundColor = Color.White;
            dtgvDTN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDTN.Location = new Point(115, 257);
            dtgvDTN.Name = "dtgvDTN";
            dtgvDTN.RowHeadersWidth = 51;
            dtgvDTN.Size = new Size(301, 346);
            dtgvDTN.TabIndex = 5;
            // 
            // dtpKT
            // 
            dtpKT.Location = new Point(591, 394);
            dtpKT.Name = "dtpKT";
            dtpKT.Size = new Size(251, 27);
            dtpKT.TabIndex = 6;
            dtpKT.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lblPhanTram);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnTang);
            groupBox1.Controls.Add(btnGiam);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblDTQua);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDTNay);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(109, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 160);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Location = new Point(281, 65);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(17, 20);
            lblPhanTram.TabIndex = 17;
            lblPhanTram.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(315, 65);
            label11.Name = "label11";
            label11.Size = new Size(21, 20);
            label11.TabIndex = 16;
            label11.Text = "%";
            // 
            // btnTang
            // 
            btnTang.BackgroundImage = (Image)resources.GetObject("btnTang.BackgroundImage");
            btnTang.BackgroundImageLayout = ImageLayout.Zoom;
            btnTang.FlatAppearance.BorderColor = Color.White;
            btnTang.FlatAppearance.BorderSize = 0;
            btnTang.FlatStyle = FlatStyle.Flat;
            btnTang.Location = new Point(238, 55);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(48, 30);
            btnTang.TabIndex = 15;
            btnTang.UseVisualStyleBackColor = true;
            // 
            // btnGiam
            // 
            btnGiam.BackgroundImage = (Image)resources.GetObject("btnGiam.BackgroundImage");
            btnGiam.BackgroundImageLayout = ImageLayout.Zoom;
            btnGiam.FlatAppearance.BorderColor = Color.White;
            btnGiam.FlatAppearance.BorderSize = 0;
            btnGiam.FlatStyle = FlatStyle.Flat;
            btnGiam.Location = new Point(238, 57);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(48, 30);
            btnGiam.TabIndex = 14;
            btnGiam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(201, 70);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 13;
            label10.Text = "VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(201, 105);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 12;
            label9.Text = "VND";
            // 
            // lblDTQua
            // 
            lblDTQua.AutoSize = true;
            lblDTQua.Location = new Point(110, 105);
            lblDTQua.Name = "lblDTQua";
            lblDTQua.Size = new Size(17, 20);
            lblDTQua.TabIndex = 11;
            lblDTQua.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 105);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 8;
            label7.Text = "Hôm qua";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 60);
            button1.Name = "button1";
            button1.Size = new Size(48, 30);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(0, 70);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // lblDTNay
            // 
            lblDTNay.AutoSize = true;
            lblDTNay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDTNay.ForeColor = Color.Red;
            lblDTNay.Location = new Point(66, 50);
            lblDTNay.Name = "lblDTNay";
            lblDTNay.Size = new Size(38, 46);
            lblDTNay.TabIndex = 9;
            lblDTNay.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 10);
            label3.Name = "label3";
            label3.Size = new Size(264, 23);
            label3.TabIndex = 8;
            label3.Text = "KẾT QUẢ BÁN HÀNG HÔM NAY";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(lblPhanTramKH);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnGiam2);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lblSLKHQua);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(lblSLKHNay);
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(884, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 160);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // lblPhanTramKH
            // 
            lblPhanTramKH.AutoSize = true;
            lblPhanTramKH.Location = new Point(281, 65);
            lblPhanTramKH.Name = "lblPhanTramKH";
            lblPhanTramKH.Size = new Size(17, 20);
            lblPhanTramKH.TabIndex = 17;
            lblPhanTramKH.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(315, 65);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 16;
            label8.Text = "%";
            // 
            // btnTang2
            // 
            btnTang2.BackgroundImage = (Image)resources.GetObject("btnTang2.BackgroundImage");
            btnTang2.BackgroundImageLayout = ImageLayout.Zoom;
            btnTang2.FlatAppearance.BorderColor = Color.White;
            btnTang2.FlatAppearance.BorderSize = 0;
            btnTang2.FlatStyle = FlatStyle.Flat;
            btnTang2.Location = new Point(238, 60);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(48, 30);
            btnTang2.TabIndex = 15;
            btnTang2.UseVisualStyleBackColor = true;
            // 
            // btnGiam2
            // 
            btnGiam2.BackgroundImage = (Image)resources.GetObject("btnGiam2.BackgroundImage");
            btnGiam2.BackgroundImageLayout = ImageLayout.Zoom;
            btnGiam2.FlatAppearance.BorderColor = Color.White;
            btnGiam2.FlatAppearance.BorderSize = 0;
            btnGiam2.FlatStyle = FlatStyle.Flat;
            btnGiam2.Location = new Point(238, 57);
            btnGiam2.Name = "btnGiam2";
            btnGiam2.Size = new Size(48, 30);
            btnGiam2.TabIndex = 14;
            btnGiam2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(154, 70);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 13;
            label12.Text = "Khách hàng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(154, 105);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 12;
            label13.Text = "Khách hàng";
            // 
            // lblSLKHQua
            // 
            lblSLKHQua.AutoSize = true;
            lblSLKHQua.Location = new Point(121, 105);
            lblSLKHQua.Name = "lblSLKHQua";
            lblSLKHQua.Size = new Size(17, 20);
            lblSLKHQua.TabIndex = 11;
            lblSLKHQua.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 105);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 8;
            label15.Text = "Hôm qua";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 60);
            button4.Name = "button4";
            button4.Size = new Size(48, 30);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Image = (Image)resources.GetObject("label16.Image");
            label16.Location = new Point(6, 70);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Image = (Image)resources.GetObject("label17.Image");
            label17.Location = new Point(0, 70);
            label17.Name = "label17";
            label17.Size = new Size(0, 20);
            label17.TabIndex = 8;
            // 
            // lblSLKHNay
            // 
            lblSLKHNay.AutoSize = true;
            lblSLKHNay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSLKHNay.ForeColor = Color.Red;
            lblSLKHNay.Location = new Point(110, 50);
            lblSLKHNay.Name = "lblSLKHNay";
            lblSLKHNay.Size = new Size(38, 46);
            lblSLKHNay.TabIndex = 9;
            lblSLKHNay.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(6, 10);
            label19.Name = "label19";
            label19.Size = new Size(211, 23);
            label19.TabIndex = 8;
            label19.Text = "KHÁCH HÀNG HÔM NAY";
            // 
            // cboNgay
            // 
            cboNgay.FormattingEnabled = true;
            cboNgay.Items.AddRange(new object[] { "Hôm nay", "Hôm qua", "Tuần trước", "Tháng trước", "Quý trước", "Năm trước", "Lựa chọn khác" });
            cboNgay.Location = new Point(604, 273);
            cboNgay.Name = "cboNgay";
            cboNgay.Size = new Size(126, 28);
            cboNgay.TabIndex = 19;
            cboNgay.SelectedIndexChanged += cboNgay_SelectedIndexChanged;
            // 
            // dtgvNV
            // 
            dtgvNV.BackgroundColor = Color.White;
            dtgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNV.Location = new Point(896, 257);
            dtgvNV.Name = "dtgvNV";
            dtgvNV.RowHeadersWidth = 51;
            dtgvNV.Size = new Size(299, 346);
            dtgvNV.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(127, 214);
            label4.Name = "label4";
            label4.Size = new Size(306, 23);
            label4.TabIndex = 18;
            label4.Text = "THỐNG KÊ DOANH THU THEO NGÀY";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(873, 214);
            label14.Name = "label14";
            label14.Size = new Size(354, 23);
            label14.TabIndex = 27;
            label14.Text = "THỐNG KÊ DOANH THU THEO NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(531, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(525, 278);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 29;
            label1.Text = "CHỌN";
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1325, 629);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(dtgvNV);
            Controls.Add(cboNgay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtpKT);
            Controls.Add(dtgvDTN);
            Controls.Add(btnLoc);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(dtpBD);
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THỐNG KÊ";
            Load += ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDTN).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBD;
        private Label lbl1;
        private Label lbl2;
        private Button btnLoc;
        private DataGridView dtgvDTN;
        private DateTimePicker dtpKT;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label lblDTNay;
        private Button button1;
        private Label label6;
        private Label lblPhanTram;
        private Label label11;
        private Button btnTang;
        private Button btnGiam;
        private Label label10;
        private Label label9;
        private Label lblDTQua;
        private Label label7;
        private GroupBox groupBox2;
        private Label lblPhanTramKH;
        private Label label8;
        private Button btnTang2;
        private Button btnGiam2;
        private Label label12;
        private Label label13;
        private Label lblSLKHQua;
        private Label label15;
        private Button button4;
        private Label label16;
        private Label label17;
        private Label lblSLKHNay;
        private Label label19;
        private ComboBox cboNgay;
        private DataGridView dtgvNV;
        private Label label4;
        private Label label14;
        private PictureBox pictureBox1;
        private Label label1;
    }
}