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

namespace GUI
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        // load data 
        private void LoadData()
        {
            try
            {
                dtgvData4.DataSource = KhachHangBLL.LayDanhSachKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // nghiệp vụ thêm
        private void menuThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã khách hàng chưa
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                return;
            }

            // Thử chuyển đổi mã khách hàng từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaKH.Text.Trim(), out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên");
                return;
            }

            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Chưa nhập SDT khách hàng");
                return;
            }

            // Tạo đối tượng DTO
            var kh = new KhachHangDTO
            {
                MaKH = maKH,
                TenKh = txtTen.Text.Trim(),
                SDT = txtSDT.Text.Trim()
            };

            // Gọi BLL để thêm dữ liệu
            string result = KhachHangBLL.ThemKhachHang(kh);

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

        // nghiệp vụ sửa
        private void menuSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã khách hàng
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                return;
            }

            if (!int.TryParse(txtMaKH.Text.Trim(), out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên");
                return;
            }


            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return;
            }

            // Kiểm tra SDT khách hàng
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Chưa nhập SDT khách hàng");
                return;
            }

            // Tạo đối tượng DTO để cập nhật
            var kh = new KhachHangDTO
            {
                MaKH = maKH,
                TenKh = txtTen.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            // Gọi BLL để xử lý cập nhật
            string result = KhachHangBLL.SuaKhachHang(kh);

            // Thông báo kết quả
            if (result == "OK")
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        // nghieepj vụ xóa
        private void menuXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập mã khách hàng hay chưa
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa.");
                return;
            }

            // Chuyển đổi mã loại sang kiểu int
            if (!int.TryParse(txtMaKH.Text.Trim(), out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số nguyên.");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi BLL để thực hiện xóa
                bool kq = KhachHangBLL.XoaKhachHang(maKH);
                if (kq)
                {
                    MessageBox.Show("Xóa khách thành công.");
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã khách hàng.");
                }
            }
        }

        private void dtgvData4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvData4.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTen.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text.Trim();
            var dt = KhachHangBLL.timKhachHangTheoTenHoacSDT(ten);
            dtgvData4.DataSource = dt;
        }

        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_MouseHover(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            txtTKMHD.Clear();   
        }
    }
}
