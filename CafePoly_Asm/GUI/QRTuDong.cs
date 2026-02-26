using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QRTuDong : Form
    {
        public QRTuDong()
        {
            InitializeComponent();
        }

        private void QRTuDong_Load(object sender, EventArgs e)
        {
            string soTien = InHoaDon.TongTT.ToString();
            string noiDung = Uri.EscapeDataString(txtNoiDung.Text.Trim());

            // Thông tin tài khoản người nhận
            string tenNH = "VCB"; // Mã ngân hàng
            string stk = "9926666990";
            string tenNguoiNhan = Uri.EscapeDataString("Le Trung Kien");

            // Tạo URL ảnh từ VietQR
            string qrUrl = $"https://img.vietqr.io/image/{tenNH}-{stk}-compact2.png?amount={soTien}&addInfo={noiDung}&accountName={tenNguoiNhan}";

            // Gán trực tiếp ảnh từ URL vào PictureBox
            picQR.Load(qrUrl);
        }
    }
}
