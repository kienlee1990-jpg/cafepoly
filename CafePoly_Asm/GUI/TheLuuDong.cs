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
    public partial class TheLuuDong : Form
    {
        public TheLuuDong()
        {
            InitializeComponent();
        }

        // Nghiệp vụ load
        private void LoadData()
        {
            try
            {
                dtgvData2.DataSource = TheLuuDongBLL.LayDanhSachthe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // load bảng thẻ
        private void TheLuuDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        // nghiệp vụ thêm
        private void menuThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã thẻ chưa
            if (string.IsNullOrWhiteSpace(txtMaThe.Text))
            {
                MessageBox.Show("Chưa nhập mã loại");
                return;
            }

            // Thử chuyển đổi mã loại từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaThe.Text.Trim(), out int maThe))
            {
                MessageBox.Show("Mã thẻ phải là số nguyên");
                return;
            }


            // Tạo đối tượng DTO
            var tld = new TheLuuDongDTO
            {
                MaThe = maThe,
                ChuSoHuu = txtChuSoHuu.Text.Trim(),
                TrangThai = cboTrangthai.Text.Trim()
            };

            // Gọi BLL để thêm dữ liệu
            string result = TheLuuDongBLL.ThemThe(tld);

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
            // Kiểm tra mã loại
            if (string.IsNullOrWhiteSpace(txtMaThe.Text))
            {
                MessageBox.Show("Chưa nhập mã thẻ");
                return;
            }

            if (!int.TryParse(txtMaThe.Text.Trim(), out int maThe))
            {
                MessageBox.Show("Mã thẻ phải là số nguyên");
                return;
            }


            // Tạo đối tượng DTO
            var tld = new TheLuuDongDTO
            {
                MaThe = maThe,
                ChuSoHuu = txtChuSoHuu.Text.Trim(),
                TrangThai = cboTrangthai.Text.Trim()
            };

            // Gọi BLL để xử lý cập nhật
            string result = TheLuuDongBLL.SuaThe(tld);

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

        // nghiệp vụ xóa
        private void menuXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã loại
            if (string.IsNullOrWhiteSpace(txtMaThe.Text))
            {
                MessageBox.Show("Chưa nhập mã thẻ");
                return;
            }

            if (!int.TryParse(txtMaThe.Text.Trim(), out int maThe))
            {
                MessageBox.Show("Mã thẻ phải là số nguyên");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thẻ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi BLL để thực hiện xóa
                bool kq = TheLuuDongBLL.XoaThe(maThe);
                if (kq)
                {
                    MessageBox.Show("Xóa thẻ thành công.");
                    LoadData(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã thẻ");
                }
            }
        }

        // nghiệp vụ xóa trắng
        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
        }

        // nghiệp vụ thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // event doubleclick vào dtgv lấy dữ liệu vào các textbox tương ứng
        private void dtgvData2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvData2.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();
                cboTrangthai.Text = row.Cells["TrangThai"].Value.ToString();

            }
        }

        // nghiệp vụ tìm kiếm theo trạng thái thẻ
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string trangThai = cboTimKiem.Text.Trim();
            var dt = TheLuuDongBLL.timKiem(trangThai);
            dtgvData2.DataSource = dt;
        }

        
    }
}
