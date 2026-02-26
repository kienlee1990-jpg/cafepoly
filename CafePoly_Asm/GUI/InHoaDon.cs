using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        public static float TongTT;

        // Nghiệp vụ load danh sách loại đồ uống
        private void LoadData()
        {
            int maHD = ManHinhChinh.maHDClick;
            string strSQL = $@"SELECT c.TenDU as N'Tên Đồ Uống' ,b.SoLuong as SL,b.DonGia as N'Đơn Giá',b.ThanhTien as N'Thành tiền' FROM dbo.HoaDon a
                                JOIN dbo.ChiTietHoaDon b ON b.MaHD = a.MaHD
                                JOIN dbo.DoUong c ON c.MaDU = b.MaDU
                                WHERE a.MaHD ='{maHD}' AND TrangThai LIKE N'Chưa thanh toán'";
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQL);
            dtgvInHD.DataSource = dt;

            // Truy vấn thông tin nhân viên, khách hàng
            string strThongTin = $@"SELECT 
                                        nv.TenNV, 
                                        hd.NgayLap, 
                                        kh.TenKH, 
                                        kh.SDT
                                    FROM HoaDon hd
                                    JOIN NhanVien nv ON nv.MaNV = hd.MaNV
                                    JOIN KhachHang kh ON kh.MaKH = hd.MaKH
                                    WHERE hd.MaHD = {maHD}";

            DataTable dtInfo = ConnectSQL.Load(strThongTin);
            if (dtInfo.Rows.Count > 0)
            {
                lblTN.Text = dtInfo.Rows[0]["TenNV"].ToString();
                lblNgayLap.Text = Convert.ToDateTime(dtInfo.Rows[0]["NgayLap"]).ToString("dd/MM/yyyy");
                lblKH.Text = dtInfo.Rows[0]["TenKH"].ToString();
                lblSDT.Text = dtInfo.Rows[0]["SDT"].ToString();
            }

            // 3. Tính tổng tiền từ cột "Thành tiền"
            decimal tongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (decimal.TryParse(row["Thành tiền"].ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            lblTong.Text = tongTien.ToString("N0"); // Hiển thị định dạng có dấu phẩy và VNĐ

            // tính chiết khấu và tổng thanh toán
            float tong;
            if (float.TryParse(lblTong.Text.Replace(",", ""), out tong))
            {
                // dùng biến tong
            }
            else
            {
                MessageBox.Show("Giá trị tổng không hợp lệ!");
            }
            float phanTramChietKhau;
            if (!float.TryParse(txtChietKhau.Text, out phanTramChietKhau))
            {
                phanTramChietKhau = 0;
            }

            float chietKhau = tong * phanTramChietKhau / 100;
            lblChietKhau.Text = chietKhau.ToString("N0");
            float tongTT = tong - chietKhau;
            lblTongTT.Text = tongTT.ToString("N0");

        }


        // load
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaHD.Text = ManHinhChinh.maHDClick.ToString();
            float tongTien = Convert.ToSingle(lblTongTT.Text);
            string strSQL = $@"UPDATE dbo.HoaDon
                                SET TongTien = {tongTien} WHERE MaHD = '{txtMaHD.Text}'";
            ConnectSQL.RunQuery(strSQL);
            
            
        }

        // load lại khi nhập dữ liệu vào ô chết khấu
        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            TongTT = Convert.ToSingle(lblTongTT.Text);
        }

        // in hóa đơn
        private void button6_Click(object sender, EventArgs e)
        {
            float tongTien = Convert.ToSingle(lblTongTT.Text);
            string strSQL = $@"UPDATE dbo.HoaDon
                                SET TrangThai =N'Đã TT chờ giao đồ',TongTien = {tongTien} WHERE MaHD = '{txtMaHD.Text}'";
            ConnectSQL.RunQuery(strSQL);
            MessageBox.Show("Thanh toán thành công !");
            this.Close();
            QRTuDong f = new QRTuDong();
            f.ShowDialog();
        }
    }
}
