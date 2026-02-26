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
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void txtMaKH_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaKH.Clear();
        }

        private void txtSDT_MouseClick(object sender, MouseEventArgs e)
        {
            txtSDT.Clear();
        }

        private void txtTinh_MouseClick(object sender, MouseEventArgs e)
        {
            txtTinh.Clear();
        }

        private void txtHuyen_MouseClick(object sender, MouseEventArgs e)
        {
            txtHuyen.Clear();
        }

        private void txtXa_MouseClick(object sender, MouseEventArgs e)
        {
            txtXa.Clear();
        }

        private void txtGhiChu_MouseClick(object sender, MouseEventArgs e)
        {
            txtGhiChu.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
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
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            // Gọi BLL để thêm dữ liệu
            string result = KhachHangBLL.ThemKhachHang(kh);
            MessageBox.Show("Thêm Khách hàng thành công");
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file ảnh
                    string imagePath = openFileDialog.FileName;

                    // Hiển thị ảnh lên PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);

                    // Tuỳ chỉnh để ảnh vừa với PictureBox (tuỳ chọn)
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
