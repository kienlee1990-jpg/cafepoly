using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void LoadData(DateTime ngBD, DateTime ngKT)
        {
            // doanh thu ngày
            try
            {
                dtgvDTN.DataSource = ThongKeBLL.ThongKeDTNgay(ngBD, ngKT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            // doanh thu nhân viên
            try
            {
                dtgvNV.DataSource = ThongKeBLL.ThongKeDTNV(ngBD, ngKT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // loadBanHangHomNay
        private void LoadKHHomNay()
        {
            // Khách hàng hôm nay
            int slkhNay = ThongKeBLL.GetKhachHang(DateTime.Today);
            lblSLKHNay.Text = slkhNay.ToString();

            // Khách hàng hôm qua
            int slkhQua = ThongKeBLL.GetKhachHang(DateTime.Today.AddDays(-1));
            lblSLKHQua.Text = slkhQua.ToString();

            double phanTram = 0;

            if (slkhQua != 0)
                phanTram = Math.Round(Math.Abs(slkhNay - slkhQua) * 100.0 / slkhQua, 1);
            else
                phanTram = slkhNay > 0 ? 100 : 0;

            lblPhanTramKH.Text = phanTram.ToString();

            // Hiện icon tăng/giảm
            btnTang2.Visible = slkhNay > slkhQua;
            btnGiam2.Visible = slkhNay < slkhQua;
        }


        // LOAD doanh thu hôm nay
        private void LoadBanHangHomNay()
        {
            decimal dtNay = ThongKeBLL.GetDoanhThu(DateTime.Today);
            decimal dtQua = ThongKeBLL.GetDoanhThu(DateTime.Today.AddDays(-1));

            lblDTNay.Text = dtNay.ToString("N0");
            lblDTQua.Text = dtQua.ToString("N0");

            double phanTram = 0;

            if (dtQua != 0)
                phanTram = Math.Round(Math.Abs((double)(dtNay - dtQua)) * 100 / (double)dtQua, 1);
            else
                phanTram = dtNay > 0 ? 100 : 0;

            lblPhanTram.Text = phanTram.ToString();

            btnTang.Visible = dtNay > dtQua;
            btnGiam.Visible = dtNay < dtQua;
        }


        // combobox
        private void LoadCBO()
        {
            if (cboNgay.Text == "Hôm nay")
            {
                dtpBD.Value = DateTime.Today;
                dtpKT.Value = DateTime.Today;
            }
            if (cboNgay.Text == "Hôm qua")
            {
                dtpBD.Value = DateTime.Today.AddDays(-1);
                dtpKT.Value = DateTime.Today.AddDays(-1);
            }
            else if (cboNgay.Text == "Tuần trước")
            {
                DateTime today = DateTime.Today;

                // Tìm ngày đầu tuần hiện tại (giả sử tuần bắt đầu từ Thứ Hai)
                int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime startOfThisWeek = today.AddDays(-diff);

                // Gán tuần trước:
                DateTime ngBD = startOfThisWeek.AddDays(-7); // Thứ Hai tuần trước
                DateTime ngKT = startOfThisWeek.AddDays(-1); // Chủ Nhật tuần trước

                // Gán vào DateTimePicker (ví dụ):
                dtpBD.Value = ngBD;
                dtpKT.Value = ngKT;
            }
            else if (cboNgay.Text == "Tháng trước")
            {
                DateTime today = DateTime.Today;

                // Lùi về ngày 1 của tháng trước
                DateTime ngBD = new DateTime(today.Year, today.Month, 1).AddMonths(-1);

                // Tìm ngày cuối tháng trước = ngày 1 của tháng này - 1 ngày
                DateTime ngKT = new DateTime(today.Year, today.Month, 1).AddDays(-1);

                // Gán vào DateTimePicker
                dtpBD.Value = ngBD;
                dtpKT.Value = ngKT;
            }
            else if (cboNgay.Text == "Quý trước")
            {
                DateTime today = DateTime.Today;

                // Xác định quý hiện tại
                int currentQuarter = (today.Month - 1) / 3 + 1;

                // Tìm quý trước
                int prevQuarter = currentQuarter - 1;
                int year = today.Year;

                if (prevQuarter == 0)
                {
                    prevQuarter = 4;
                    year--; // Lùi về năm trước nếu hiện tại là quý 1
                }

                // Ngày bắt đầu quý trước
                int startMonth = (prevQuarter - 1) * 3 + 1;
                DateTime ngBD = new DateTime(year, startMonth, 1);

                // Ngày kết thúc quý trước = ngày đầu quý hiện tại - 1 ngày
                int currentQuarterStartMonth = (currentQuarter - 1) * 3 + 1;
                DateTime ngKT = new DateTime(today.Year, currentQuarterStartMonth, 1).AddDays(-1);

                // Gán vào DateTimePicker
                dtpBD.Value = ngBD;
                dtpKT.Value = ngKT;

            }
            else if (cboNgay.Text == "Năm trước")
            {
                DateTime today = DateTime.Today;

                // Năm trước
                int namTruoc = today.Year - 1;

                // Ngày bắt đầu: 01/01 của năm trước
                DateTime ngBD = new DateTime(namTruoc, 1, 1);

                // Ngày kết thúc: 31/12 của năm trước
                DateTime ngKT = new DateTime(namTruoc, 12, 31);

                // Gán vào DateTimePicker
                dtpBD.Value = ngBD;
                dtpKT.Value = ngKT;
            }
            else if (cboNgay.Text == "Lựa chọn khác")
            {
                dtpBD.Visible = true;
                dtpKT.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
            }
        }

        // load
        private void ThongKe_Load(object sender, EventArgs e)
        {
            // Lấy giá trị DateTime trực tiếp từ DateTimePicker
            DateTime ngayBatDau = dtpBD.Value.Date;
            DateTime ngayKetThuc = dtpKT.Value.Date.AddDays(1).AddTicks(-1); // Đưa về cuối ngày

            LoadData(ngayBatDau, ngayKetThuc);
            // hiển thị thông tin groupbox bán hàng hôm nay
            LoadBanHangHomNay();
            LoadKHHomNay();

        }

        // nghiệp vụ lọc 
        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Lấy giá trị DateTime trực tiếp từ DateTimePicker
            DateTime ngayBatDau = dtpBD.Value.Date;
            DateTime ngayKetThuc = dtpKT.Value.Date.AddDays(1).AddTicks(-1); // Đưa về cuối ngày

            LoadData(ngayBatDau, ngayKetThuc);
            dtpBD.Visible = false;
            dtpKT.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
        }

        // load doanh thu theo combobox
        private void cboNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCBO();
            // Lấy giá trị DateTime trực tiếp từ DateTimePicker
            DateTime ngayBatDau = dtpBD.Value.Date;
            DateTime ngayKetThuc = dtpKT.Value.Date.AddDays(1).AddTicks(-1); // Đưa về cuối ngày

            LoadData(ngayBatDau, ngayKetThuc);

        }

        
    }
}
