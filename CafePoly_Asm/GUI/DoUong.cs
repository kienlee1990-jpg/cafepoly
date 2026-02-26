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
    public partial class DoUong : Form
    {
        public DoUong()
        {
            InitializeComponent();
        }

        // Nghiệp vụ load danh sách loại đồ uống
        private void LoadData()
        {
            try
            {
                dtgvData3.DataSource = DoUongBLL.LayDanhSachDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // load danh sách
        private void DoUong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // nghiệp vụ thêm
        private void menuThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã loại chưa
            if (string.IsNullOrWhiteSpace(txtMaDU.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                return;
            }

            // Thử chuyển đổi mã đồ uống từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaDU.Text.Trim(), out int maDU))
            {
                MessageBox.Show("Mã đồ uống phải là số nguyên");
                return;
            }

            // Kiểm tra tên đồ uống
            if (string.IsNullOrWhiteSpace(txtTenDU.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                return;
            }

            // Kiểm tra xem người dùng đã nhập mã loại chưa
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại");
                return;
            }

            // Thử chuyển đổi mã loại từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaLoai.Text.Trim(), out int maLoai))
            {
                MessageBox.Show("Mã loại phải là số nguyên");
                return;
            }

            // kiểm tra tính hợp lệ của giá
            float gia;
            if (!float.TryParse(txtDonGia.Text, out gia))
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!");
                return;
            }

            // Tạo đối tượng DTO
            var du = new DoUongDTO
            {
                MaDU = maDU,
                MaLoai = maLoai,
                TenDU = txtTenDU.Text.Trim(),
                HinhAnh = txtHinhAnh.Text.Trim(),
                DonGia = gia

            };

            // Gọi BLL để thêm dữ liệu
            string result = DoUongBLL.ThemDoUong(du);

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
            // Kiểm tra mã đồ uống
            if (string.IsNullOrWhiteSpace(txtMaDU.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                return;
            }

            if (!int.TryParse(txtMaDU.Text.Trim(), out int maDU))
            {
                MessageBox.Show("Mã đồ uống phải là số nguyên");
                return;
            }

            // Kiểm tra mã loại
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại");
                return;
            }

            if (!int.TryParse(txtMaLoai.Text.Trim(), out int maLoai))
            {
                MessageBox.Show("Mã loại phải là số nguyên");
                return;
            }

            // kiểm tra tính hợp lệ của giá
            float gia;
            if (!float.TryParse(txtDonGia.Text, out gia))
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!");
                return;
            }

            // Kiểm tra tên loại
            if (string.IsNullOrWhiteSpace(txtTenDU.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                return;
            }

            // Tạo đối tượng DTO để cập nhật
            var du = new DoUongDTO
            {
                MaDU = maDU,
                MaLoai = maLoai,
                TenDU = txtTenDU.Text.Trim(),
                DonGia = gia,
                HinhAnh = txtHinhAnh.Text.Trim(),

            };

            // Gọi BLL để xử lý cập nhật
            string result = DoUongBLL.SuaDoUong(du);

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

        private void dtgvData3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvData3.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaDU.Text = row.Cells["MaDU"].Value.ToString();
                txtTenDU.Text = row.Cells["TenDU"].Value.ToString();
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
            }
        }

        // nghiệp vụ xóa trắng
        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaDU.Clear();
            txtTenDU.Clear();
            txtMaLoai.Clear();
            txtDonGia.Clear();
            txtHinhAnh.Clear();
        }

        // nghiệp vụ thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // nghiệp vụ xóa
        private void menuXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập mã loại hay chưa
            if (string.IsNullOrWhiteSpace(txtMaDU.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đồ uống cần xóa.");
                return;
            }

            // Chuyển đổi mã loại sang kiểu int
            if (!int.TryParse(txtMaDU.Text.Trim(), out int maDU))
            {
                MessageBox.Show("Mã đồ phải là số nguyên.");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Loại đồ uống này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi BLL để thực hiện xóa
                bool kq = DoUongBLL.XoaDoUong(maDU);
                if (kq)
                {
                    MessageBox.Show("Xóa đồ uống thành công.");
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã đồ uống.");
                }
            }
        }


        // nghiệp vụ tìm kiếm theo tên đồ uống
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text.Trim();
            var dt = DoUongBLL.timDoUongTheoTen(ten);
            dtgvData3.DataSource = dt;
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
        }
    }
}
