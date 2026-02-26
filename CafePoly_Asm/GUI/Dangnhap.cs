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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Dangnhap : Form
    {


        public Dangnhap()
        {
            InitializeComponent();
        }
        public static string MatKhau;
        public static int MaNV;
        public static int quyen;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // gán quyền
            if (rdoThuNgan.Checked)
            {
                quyen = 1;
            }
            else if (rdoQLy.Checked)
            {
                quyen = 0;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (string.IsNullOrEmpty(txtDangNhap.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mã đăng nhập");
                txtDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txtMatKhau.Focus();
                return;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự");
                txtMatKhau.Focus();
                return;
            }

            string maNV = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            if (NhanvienBLL.DangNhap(maNV, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công");
                MatKhau = txtMatKhau.Text;
                MaNV = int.Parse(txtDangNhap.Text);
                // chuyển sang form chính
                ManHinhChinh f = new ManHinhChinh();
                f.ShowDialog();

                if (!chkNhoMatKhau.Checked)
                {
                    txtDangNhap.Clear();
                    txtMatKhau.Clear();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin mã đăng nhập hoặc mật khẩu");
                txtDangNhap.Focus();
            }

            


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnDangNhap.PerformClick();  // kích hoạt nút đăng nhập
            }
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            txtDangNhap.Clear();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }

        private void btnHien_MouseClick(object sender, MouseEventArgs e)
        {
            btnHien.Visible = false;
            btnAn.Visible = true;
            txtMatKhau.PasswordChar = '\0';


        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            btnHien.Visible = true;
            btnAn.Visible = false;
            txtMatKhau.PasswordChar = '*';

        }
    }
}
