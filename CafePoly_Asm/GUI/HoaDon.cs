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
using DAL;
using DTO;

namespace GUI
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                dtgvHD.DataSource = HoaDonBLL.LayDanhSachHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (string.IsNullOrWhiteSpace(txtTKMaHD.Text))
                txtTKMaHD.Text = "Theo mã HD";

            if (string.IsNullOrWhiteSpace(txtTKDU.Text))
                txtTKDU.Text = "Theo mã, tên đồ uống";

            if (string.IsNullOrWhiteSpace(txtTKKH.Text))
                txtTKKH.Text = "Theo mã, tên khách hàng";

        }

        // kiểm tra dữ liệu đầu vào
        public HoaDonDTO checkData()
        {
            // Kiểm tra mã hóa đơn
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn");
                return null;
            }
            if (!int.TryParse(txtMaHD.Text.Trim(), out int maHD))
            {
                MessageBox.Show("Mã hóa đơn phải là số nguyên");
                return null;
            }

            // Kiểm tra trạng thái
            if (string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Chưa cập nhật trạng thái");
                return null;
            }

            // Kiểm tra mã nhân viên
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                return null;
            }
            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên");
                return null;
            }

            // Kiểm tra mã khách hàng
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                return null;
            }
            if (!int.TryParse(txtMaKH.Text.Trim(), out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên");
                return null;
            }

            // Kiểm tra mã thẻ
            if (string.IsNullOrWhiteSpace(txtMaThe.Text))
            {
                MessageBox.Show("Chưa nhập mã thẻ");
                return null;
            }
            if (!int.TryParse(txtMaThe.Text.Trim(), out int maThe))
            {
                MessageBox.Show("Mã thẻ phải là số nguyên");
                return null;
            }

            // Kiểm tra tổng tiền
            if (string.IsNullOrWhiteSpace(txtTongTien.Text))
            {
                MessageBox.Show("Chưa nhập tổng tiền");
                return null;
            }
            if (!decimal.TryParse(txtTongTien.Text.Trim(), out decimal tongTien))
            {
                MessageBox.Show("Tổng tiền phải là số hợp lệ");
                return null;
            }

            // Nếu tất cả hợp lệ, trả về đối tượng DTO
            return new HoaDonDTO
            {
                MaHD = maHD,
                MaNV = maNV,
                MaKH = maKH,
                MaThe = maThe,
                NgayLap = dtpNgayLap.Value,
                TrangThai = txtTrangThai.Text.Trim(),
                TongTien = tongTien
            };
        }

        // load bảng hóa đơn
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // nghiệp vụ thêm
        private void menuThem_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = checkData();
            if (hd == null) return;

            // Gọi BLL để thêm dữ liệu
            string result = HoaDonBLL.ThemHD(hd);

            // Xử lý kết quả
            if (result == "OK")
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        //kick đúp chuột lấy dữ liệu lên textbox
        private void dtgvHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvHD.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                dtpNgayLap.Text = row.Cells["NgayLap"].Value.ToString();
            }
        }

        // nghiệp vụ xóa trắng
        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtMaNV.Clear();
            txtTrangThai.Clear();
            txtTongTien.Clear();
            txtMaThe.Clear();
        }

        // nghiệp vụ xóa
        private void menuXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập mã hóa đơn hay chưa
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa.");
                return;
            }

            // Chuyển đổi mã loại sang kiểu int
            if (!int.TryParse(txtMaHD.Text.Trim(), out int maHD))
            {
                MessageBox.Show("Mã hóa đơn phải là số nguyên.");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi BLL để thực hiện xóa
                bool kq = HoaDonBLL.XoaHD(maHD);
                if (kq)
                {
                    MessageBox.Show("Xóa hóa đơn thành công.");
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã hóa đơn .");
                }
            }
        }

        // nút thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // nghiệp vụ sửa
        private void menuSua_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = checkData();
            if (hd == null) return;
            // Gọi BLL để thêm dữ liệu
            string result = HoaDonBLL.SuaHD(hd);

            // Xử lý kết quả
            if (result == "OK")
            {
                MessageBox.Show("Sửa dữ liệu thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // lấy mã hóa đơn 
            int? maHD;

            string input = txtTKMaHD.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                maHD = null;
            }
            else if (!int.TryParse(input, out int result))
            {
                maHD = 0;
            }
            else
            {
                maHD = result;
            }

            string DU = txtTKDU.Text.Trim();
            string KH = txtTKKH.Text.Trim();

            DataTable dt = HoaDonDAL.TimHd(maHD, DU, KH);
            dtgvHD.DataSource = dt;



        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
