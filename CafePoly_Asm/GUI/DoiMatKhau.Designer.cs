namespace GUI
{
    partial class DoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatKhauCu = new TextBox();
            txtLaiMatKhauMoi = new TextBox();
            txtMatKhauMoi = new TextBox();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 52);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 85);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(233, 12);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(226, 27);
            txtMatKhauCu.TabIndex = 3;
            // 
            // txtLaiMatKhauMoi
            // 
            txtLaiMatKhauMoi.Location = new Point(233, 78);
            txtLaiMatKhauMoi.Name = "txtLaiMatKhauMoi";
            txtLaiMatKhauMoi.Size = new Size(226, 27);
            txtLaiMatKhauMoi.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(233, 45);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(226, 27);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.Red;
            btnDoiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoiMatKhau.ForeColor = SystemColors.ButtonHighlight;
            btnDoiMatKhau.Location = new Point(136, 126);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(147, 36);
            btnDoiMatKhau.TabIndex = 17;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(0, 0, 192);
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(336, 126);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 36);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(469, 182);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtLaiMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMatKhauCu;
        private TextBox txtLaiMatKhauMoi;
        private TextBox txtMatKhauMoi;
        private Button btnDoiMatKhau;
        private Button btnThoat;
    }
}