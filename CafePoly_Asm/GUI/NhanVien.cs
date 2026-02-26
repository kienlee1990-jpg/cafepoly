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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtgvData.DataSource = NhanvienBLL.LayDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            // mã hóa mật khẩu
            foreach (DataGridViewRow row in dtgvData.Rows)
            {
                if (row.Cells["MatKhau"].Value != null)
                {
                    string original = row.Cells["MatKhau"].Value.ToString();
                    row.Cells["MatKhau"].Value = new string('*', original.Length); // ***...
                }
            }
        }

        // load bảng nhân viên
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Nghiệp vụ thêm nhân viên
        private void menuThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chưa nhập mã Nhân viên");
                return;
            }

            // Thử chuyển đổi mã nhân viên từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên");
                return;
            }
            var nv = new NhanVienDTO
            {
                MaNV = maNV,
                TenNV = txtTenNV.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            string result = NhanvienBLL.ThemNhanVien(nv);

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

        // Nghiệp vụ sửa
        private void menuSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chưa nhập mã Nhân viên");
                return;
            }

            // Thử chuyển đổi mã nhân viên từ chuỗi sang số nguyên
            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên");
                return;
            }
            var nv = new NhanVienDTO
            {
                MaNV = maNV,
                TenNV = txtTenNV.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            string result = NhanvienBLL.SuaNhanVien(nv);

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

        // event doubleclick vào dtgv lấy dữ liệu vào các textbox tương ứng
        private void dtgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvData.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        // Nghiêp vụ xóa
        private void menuXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = NhanvienBLL.XoaNhanVien(maNV);
                if (kq)
                {
                    MessageBox.Show("Xóa nhân viên thành công.");
                    LoadData(); // Gọi lại hàm load DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại mã nhân viên.");
                }
            }
        }

        // xóa trắng
        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        // Thoát khỏi form Nhân viên
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text.Trim();
            var dt = NhanvienBLL.TimNhanVienTheoTen(ten);
            dtgvData.DataSource = dt;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }
    }
}
