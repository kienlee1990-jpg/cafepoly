namespace GUI
{
    partial class QRTuDong
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
            txtSoTien = new TextBox();
            txtNoiDung = new TextBox();
            picQR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            SuspendLayout();
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(68, 123);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(274, 27);
            txtSoTien.TabIndex = 0;
            txtSoTien.Text = "Số tiền";
            txtSoTien.Visible = false;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(68, 201);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(274, 27);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.Text = "Nội dung";
            txtNoiDung.Visible = false;
            // 
            // picQR
            // 
            picQR.Location = new Point(68, 39);
            picQR.Name = "picQR";
            picQR.Size = new Size(359, 326);
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            picQR.TabIndex = 3;
            picQR.TabStop = false;
            // 
            // QRTuDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(picQR);
            Controls.Add(txtNoiDung);
            Controls.Add(txtSoTien);
            Name = "QRTuDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mã QR";
            Load += QRTuDong_Load;
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoTien;
        private TextBox txtNoiDung;
        private PictureBox picQR;
    }
}