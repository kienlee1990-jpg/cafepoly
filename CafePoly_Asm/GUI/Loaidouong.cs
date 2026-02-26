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
    public partial class Loaidouong : Form
    {
        public Loaidouong()
        {
            InitializeComponent();
        }
        // Nghiệp vụ load danh sách loại đồ uống
        private void LoadData()
        {
            try
            {
                dtgvData1.DataSource = LoaiDoUongBLL.LayDanhSachLoaiDoUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // load bảng loại dồ uống
        private void Loaidouong_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        // nghiệp vụ thêm
        private void menuThem_Click(object sender, EventArgs e)
        {


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

            // Kiểm tra tên loại
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên loại");
                return;
            }

            // Tạo đối tượng DTO
            var ldu = new LoaiDoUongDTO
            {
                MaLoai = maLoai,
                TenLoai = txtTenLoai.Text.Trim()
            };

            // Gọi BLL để thêm dữ liệu
            string result = LoaiDoUongBLL.ThemLoaiDoUong(ldu);

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

        private void menuSua_Click(object sender, EventArgs e)
        {
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

            // Kiểm tra tên loại
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên loại");
                return;
            }

            // Tạo đối tượng DTO để cập nhật
            var ldu = new LoaiDoUongDTO
            {
                MaLoai = maLoai,
                TenLoai = txtTenLoai.Text.Trim()
            };

            // Gọi BLL để xử lý cập nhật
            string result = LoaiDoUongBLL.SuaLoaiDoUong(ldu);

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

        private void menuXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập mã loại hay chưa
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại cần xóa.");
                return;
            }

            // Chuyển đổi mã loại sang kiểu int
            if (!int.TryParse(txtMaLoai.Text.Trim(), out int maLoai))
            {
                MessageBox.Show("Mã loại phải là số nguyên.");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Loại đồ uống này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi BLL để thực hiện xóa
                bool kq = LoaiDoUongBLL.XoaLoaiDoUong(maLoai);
                if (kq)
                {
                    MessageBox.Show("Xóa loại đồ uống thành công.");
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã loại.");
                }
            }
        }

        // nghiệp vụ xóa trắng
        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtTimKiem.Clear();

        }

        // nghiệp vụ thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // event doubleclick vào dtgv lấy dữ liệu vào các textbox tương ứng
        private void dtgvData1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvData1.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text.Trim();
            var dt = LoaiDoUongBLL.timLoaiDoUongTheoTen(ten);
            dtgvData1.DataSource = dt;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }
    }
}
