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
using Microsoft.Data.SqlClient;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();

        }

        // đổi mật khẩu
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLai = txtLaiMatKhauMoi.Text;

            if (matKhauCu != Dangnhap.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            if (string.IsNullOrEmpty(matKhauMoi) || matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!");
                return;
            }

            if (matKhauMoi != nhapLai)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!");
                return;
            }

            bool result = NhanvienBLL.DoiMatKhau(Dangnhap.MaNV, matKhauMoi);
            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Dangnhap.MatKhau = matKhauMoi; // cập nhật mật khẩu đã đổi
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
