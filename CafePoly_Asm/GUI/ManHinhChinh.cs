using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ManHinhChinh : Form
    {
        public static int maHDClick;
        
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void nhânViênTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.ShowDialog();

        }

        private void loạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaidouong f = new Loaidouong();
            f.ShowDialog();
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLuuDong f = new TheLuuDong();
            f.ShowDialog();
        }

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUong f = new DoUong();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Dangnhap f = new Dangnhap();
            f.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }

        private void xemLịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            InHoaDon f = new InHoaDon();
            f.ShowDialog();
        }

        private void thốngKêDoanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.ShowDialog();
        }

        // load màn hình thu ngân
        private void ManHinhThuNgan()
        {
            nhânViênTàiKhoảnToolStripMenuItem.Visible = false;
            nhậpTồnKhoHàngHóaToolStripMenuItem.Visible=false;
            nguyênLiệuToolStripMenuItem.Visible=!false;
            côngThứcToolStripMenuItem.Visible=false ;
            thốngKêToolStripMenuItem.Visible = false ;
            quảnLýKháchHàngToolStripMenuItem.Visible = false ;
            nguyênLiệuToolStripMenuItem.Visible =false ;
            côngThứcToolStripMenuItem.Visible = false;
        }
        // load form thẻ
        private void loadTable()
        {
            try
            {
                lsvThe.Items.Clear();
                lsvThe.View = View.LargeIcon;
                lsvThe.LargeImageList = imageList1;

                string trangThai = "";
                if (rdoYes.Checked)
                    trangThai = "Đang sử dụng";
                else if (rdoNo.Checked)
                    trangThai = "Trống";
                if (rdoYes.Checked)
                    btnGiaoDo.Visible = true; // Chỉ hiển thị khi chọn "Yes"
                else
                    btnGiaoDo.Visible = false;

                DataTable dt = TheLuuDongBLL.LayDanhSachThe2(trangThai);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string maThe = row["MaThe"].ToString();
                        string tt = row["TrangThai"].ToString().Trim().ToLower();
                        ListViewItem item = new ListViewItem(maThe);
                        item.Tag = maThe;

                        if (tt == "đang sử dụng")
                            item.ImageIndex = 1;
                        else if (tt == "trống")
                            item.ImageIndex = 2;
                        else
                            item.ImageIndex = 2;

                        lsvThe.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thẻ: " + ex.Message);
            }
        }

        // load danh sách đồ uống
        private void loadTable1()
        {
            try
            {
                lsvOD.Items.Clear();
                lsvOD.View = View.LargeIcon;
                lsvOD.LargeImageList = imageList1;

                DataTable dt = DoUongBLL.LayDanhSachDoUong();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenDU = row["TenDU"]?.ToString().Trim() ?? "Không tên";
                        string hinhAnh = row["HinhAnh"]?.ToString().Trim();
                        decimal donGia = row["DonGia"] != DBNull.Value ? Convert.ToDecimal(row["DonGia"]) : 0;

                        // Gộp Tên đồ uống + Đơn giá để hiển thị
                        string hienThi = $"{tenDU}";// - {donGia:N0} VNĐ";

                        ListViewItem item = new ListViewItem(hienThi);

                        // Gán hình ảnh nếu có trong imageList1
                        if (!string.IsNullOrEmpty(hinhAnh) && imageList1.Images.ContainsKey(hinhAnh))
                        {
                            item.ImageKey = hinhAnh;
                        }
                        else
                        {
                            item.ImageIndex = -1; // hoặc đặt ảnh mặc định nếu muốn
                        }

                        lsvOD.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu đồ uống: " + ex.Message);
            }
        }

        //load lấy tên nhân viên thu ngân
        private void GetTenNVTN()
        {
            int maNV = Dangnhap.MaNV; // Lấy từ biến static đã đăng nhập
            string tenNV = NhanvienBLL.LayTenNhanVien(maNV);

            if (!string.IsNullOrEmpty(tenNV))
                txtTenNVBH.Text = tenNV;
            else
                txtTenNVBH.Text = "Không tìm thấy tên nhân viên";
        }

        // code phần order
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTimKiem.Text.Trim();

                // Gọi hàm tìm kiếm từ Business Logic Layer
                DataTable dt = DoUongBLL.timDoUongTheoTen(ten);

                // Xóa danh sách cũ
                lsvOD.Items.Clear();
                lsvOD.View = View.LargeIcon;
                lsvOD.LargeImageList = imageList1;

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenDU = row["TenDU"].ToString().Trim();
                        string hinhAnh = row["HinhAnh"].ToString().Trim(); // Key hình ảnh trong imageList1

                        ListViewItem item = new ListViewItem(tenDU);
                        item.ImageKey = hinhAnh;

                        lsvOD.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đồ uống nào phù hợp.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm đồ uống: " + ex.Message);
            }
        }

        private void LoadCTHD()
        {
            try
            {
                dtgvHoaDon.DataSource = ChiTietHoaDonBLL.LayDanhSachCTHD(btnTheDaChon.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // click để hiện thị tên thẻ lên button
        private void lsvThe_Click(object sender, EventArgs e)
        {
            // Lấy mã thẻ từ item được chọn
            ListViewItem selectedItem = lsvThe.SelectedItems[0];
            int maThe = int.Parse(selectedItem.Tag.ToString());
            btnTheDaChon.Text = maThe.ToString();

            // Gán Tag cho nút btnTheDaChon để dùng lại trong LoadDoUongDaGoi
            btnTheDaChon.Tag = maThe;

            // Gọi hàm để load chi tiết đồ uống đã gọi
            LoadDoUongDaGoi();

            // lấy tên khách hàng gán vào ô txtTKKH
            string strSQL = $@"SELECT b.TenKH FROM dbo.HoaDon a
                                JOIN dbo.KhachHang b  ON  b.MaKH = a.MaKH
                                WHERE a.MaThe ='{btnTheDaChon.Text}' AND a.TrangThai <>N'Hoàn thành'";
            txtTKKH.Text = ConnectSQL.ExcuteScalar_string(strSQL);

            // lấy mã hóa đơn gán vào ô txtMaHD
            strSQL = $@"SELECT MaHD FROM dbo.HoaDon 
                           WHERE MaThe ='{btnTheDaChon.Text}' AND TrangThai <> N'Hoàn thành'";
            txtMaHD.Text = ConnectSQL.ExcuteScalar_string(strSQL);
            maHDClick = ConnectSQL.ExcuteScalar_int(strSQL);

        }

        // hiển thị lên danh sách thanh toán
        private void LoadDoUongDaGoi()
        {
            int maThe = (int)btnTheDaChon.Tag;

            string strSQL = $@"SELECT c.TenDU,a.SoLuong,a.DonGia,a.ThanhTien FROM ChiTietHoaDon a 
                                JOIN HoaDon b ON a.MaHD = b.MaHD 
                                JOIN DoUong c ON a.MaDU = c.MaDU 
                                JOIN The d ON b.MaThe = d.MaThe
                                WHERE b.MaThe = {maThe}
                                AND b.TrangThai <> N'Hoàn thành'
                                AND d.TrangThai = N'Đang sử dụng'";
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQL);
            dtgvHoaDon.DataSource = dt;
            // Tính tổng tiền từ cột ThanhTien
            decimal tongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (decimal.TryParse(row["ThanhTien"].ToString(), out decimal giaTri))
                {
                    tongTien += giaTri;
                }
            }

            // Gán vào TextBox txtTongTien
            lblTongTien.Text = tongTien.ToString("N0") + "VND"; // Định dạng có dấu phân cách hàng nghìn

        }

        // nghiệp vụ thêm mới đồ uống vào danh sách order        
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int maHD;
            if (!int.TryParse(txtMaHD.Text, out maHD))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ.");
                return;
            }

            string sql = $@"SELECT MaDU, DonGia FROM DoUong WHERE TenDU = N'{cboDoUong.Text}'";
            DataTable dt = ConnectSQL.Load(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đồ uống trong cơ sở dữ liệu.");
                return;
            }

            int maDU = Convert.ToInt32(dt.Rows[0]["MaDU"]);
            int donGia = Convert.ToInt32(dt.Rows[0]["DonGia"]);
            int soLuong = Convert.ToInt32(nudSL.Value);

            // 1. Kiểm tra xem ChiTietHoaDon đã có đồ uống này chưa
            string checkExistQuery = $@"SELECT SoLuong FROM ChiTietHoaDon 
                                WHERE MaHD = {maHD} AND MaDU = {maDU}";
            DataTable existDT = ConnectSQL.Load(checkExistQuery);

            if (existDT.Rows.Count > 0)
            {
                // 2. Nếu đã tồn tại, cập nhật số lượng
                int soLuongCu = Convert.ToInt32(existDT.Rows[0]["SoLuong"]);
                int soLuongMoi = soLuongCu + soLuong;

                string updateQuery = $@"UPDATE ChiTietHoaDon 
                                SET SoLuong = {soLuongMoi}, DonGia = {donGia}
                                WHERE MaHD = {maHD} AND MaDU = {maDU}";
                ConnectSQL.RunQuery(updateQuery);
            }
            else
            {
                // 3. Nếu chưa có, thêm mới
                string insertQuery = $@"INSERT INTO ChiTietHoaDon (MaHD, MaDU, SoLuong, DonGia)
                                VALUES ({maHD}, {maDU}, {soLuong}, {donGia})";
                ConnectSQL.RunQuery(insertQuery);
            }

            // 4. Load lại chi tiết hóa đơn
            LoadDoUongDaGoi();

            // 5. Tính tổng tiền và hiển thị
            string tongTienQuery = $@"SELECT SUM(SoLuong * DonGia) FROM ChiTietHoaDon WHERE MaHD = {maHD}";
            object result = ConnectSQL.ExcuteScalar_int(tongTienQuery);
            if (result != DBNull.Value)
            {
                int tongTien = Convert.ToInt32(result);
                lblTongTien.Text = tongTien.ToString("N0") + " đ";
            }
            else
            {
                lblTongTien.Text = "0 đ";
            }
            nudSL.Value = 0;
        }

        // click để lấy tên đồ uống      
        private void lsvOD_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không
            if (lsvOD.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvOD.SelectedItems[0];

                // Giả sử TenDU nằm ở SubItem đầu tiên (cột thứ 1)
                string tenDoUong = selectedItem.SubItems[0].Text;
                // Gán giá trị vào ComboBox
                cboDoUong.Text = tenDoUong;
            }
        }

        // formload màn hình chính
        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            loadHinhanh();
            loadTable();
            loadTable1();
            GetTenNVTN();
            int quyen = Dangnhap.quyen;
            if (quyen > 0)
            {
                ManHinhThuNgan();
            }
        }

        // nút tất cả
        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        // nút thẻ tắt
        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        // nút thẻ mở
        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        // mở thẻ
        private void lsvThe_DoubleClick(object sender, EventArgs e)
        {
            // tạo hóa đơn 
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(btnTheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn thẻ và nhập mã khách hàng trước khi mở thẻ.");
                return;
            }

            int maKH;
            int maThe;

            if (!int.TryParse(txtMaKH.Text, out maKH) || !int.TryParse(btnTheDaChon.Text, out maThe))
            {
                MessageBox.Show("Mã khách hàng hoặc mã thẻ không hợp lệ!");
                return;
            }

            // Kiểm tra trạng thái thẻ
            string sqlCheckTrangThai = $"SELECT TrangThai FROM The WHERE MaThe = {maThe}";
            DataTable dtTrangThai = ConnectSQL.Load(sqlCheckTrangThai);

            if (dtTrangThai.Rows.Count > 0)
            {
                string trangThai = dtTrangThai.Rows[0]["TrangThai"].ToString();
                if (trangThai == "Đang sử dụng")
                {
                    MessageBox.Show("Thẻ đang được sử dụng! Vui lòng chọn thẻ khác.");
                    return;
                }
            }

            string strSQL = $@"INSERT INTO HoaDon (NgayLap, MaNV, MaKH, MaThe, TongTien, TrangThai)
                                    VALUES ('{DateTime.Now:yyyy-MM-dd HH:mm:ss}',
                                              {Dangnhap.MaNV}, {Convert.ToInt32(txtMaKH.Text)},
                                               {Convert.ToInt32(btnTheDaChon.Text)}, 0, N'Chưa thanh toán')";

            ConnectSQL.RunQuery(strSQL);

            // mở thẻ

            if (lsvThe.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvThe.SelectedItems[0];

                if (item.Tag != null && int.TryParse(item.Tag.ToString(), out maThe))
                {
                    var tld = new TheLuuDongDTO
                    {
                        MaThe = maThe,
                        TrangThai = "Đang sử dụng"
                    };

                    string result = TheLuuDongBLL.SuaThe(tld);


                    loadTable(); // Tải lại danh sách thẻ sau khi cập nhật
                }
                else
                {
                    var tld = new TheLuuDongDTO
                    {
                        TrangThai = "Trống"
                    };

                    string result = TheLuuDongBLL.SuaThe(tld);
                    MessageBox.Show("Thẻ đã được mở");

                    loadTable(); // Tải lại danh sách thẻ sau khi cập nhật

                }

                // lấy mã hóa đơn gán vào ô txtMaHD
                strSQL = $@"SELECT MaHD FROM dbo.HoaDon 
                           WHERE MaThe ='{btnTheDaChon.Text}' AND TrangThai <> N'Hoàn thành'";
                txtMaHD.Text = ConnectSQL.ExcuteScalar_string(strSQL);
                maHDClick = ConnectSQL.ExcuteScalar_int(strSQL);
            }
        }

        // load màn hình chính
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadTable();
            loadTable1();
        }

        // nghiệp vụ giao đồ uống
        private void btnGiaoDo_Click(object sender, EventArgs e)
        {
            if (lsvThe.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvThe.SelectedItems[0];

                if (item.Tag != null && int.TryParse(item.Tag.ToString(), out int maThe))
                {
                    var tld = new TheLuuDongDTO
                    {
                        MaThe = maThe,
                        TrangThai = "Trống"
                    };

                    string result = TheLuuDongBLL.SuaThe(tld);
                    MessageBox.Show("Giao đồ thành công");

                    loadTable(); // Tải lại danh sách thẻ sau khi cập nhật
                }
                else
                {


                    loadTable(); // Tải lại danh sách thẻ sau khi cập nhật
                    //MessageBox.Show("Mã thẻ không hợp lệ! Không thể chuyển trạng thái.");
                }
            }
            string strSQL = $@"UPDATE dbo.HoaDon
                              SET TrangThai = N'Hoàn thành'
                              WHERE MaThe = '{btnTheDaChon.Text}'";
            ConnectSQL.RunQuery(strSQL);
        }

        // tìm kiếm khách hàng đã lưu trong danh sách
        private void btnTKKH_Click(object sender, EventArgs e)
        {
            string ten = txtTKKH.Text.Trim();
            var dt = KhachHangBLL.timKhachHangTheoTenHoacSDT(ten);
            dtgvKH.DataSource = dt;
            dtgvKH.Visible = true;
        }

        // chọn khách hàng sau khi tìm kiếm
        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvKH.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong dòng được chọn và gán vào các TextBox
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTKKH.Text = row.Cells["TenKH"].Value.ToString();

            }
            dtgvKH.Visible = false;
        }

        // click để lấy mã đồ uống cần xóa
        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvHoaDon.Rows[e.RowIndex];
                txtTenDUXoa.Text = row.Cells["TenDU"].Value.ToString();
                string strSQL = $@"SELECT MaDU FROM dbo.DoUong WHERE TenDU = N'{txtTenDUXoa.Text}'";
                txtMaDUXoa.Text = ConnectSQL.ExcuteScalar_int(strSQL).ToString();

            }
        }

        // nút xóa dồ uống
        private void btnXoaCTDU_Click(object sender, EventArgs e)
        {
            // Chuyển đổi mã đồ uống sang kiểu int
            if (!int.TryParse(txtMaDUXoa.Text.Trim(), out int maDU))
            {
                MessageBox.Show("Mã đồ phải là số nguyên.");
                return;
            }
            // Chuyển đổi mã hóa đơn sang kiểu int
            if (!int.TryParse(txtMaHD.Text.Trim(), out int maHD))
            {
                MessageBox.Show("Mã đồ phải là số nguyên.");
                return;
            }
            // Gọi BLL để thực hiện xóa
            bool kq = ChiTietHoaDonBLL.XoaHDCT(maHD, maDU);
            if (kq)
            {
                MessageBox.Show("Xóa đồ uống thành công.");
                LoadCTHD(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show("Xóa thất bại. Kiểm tra lại .");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }
               
        private void loadHinhanh()
        {
            // Thiết lập kích thước ảnh nếu cần
            imageList1.ImageSize = new Size(90, 80);

            // Lấy tất cả đường dẫn ảnh trong thư mục
            string[] imagePaths = Directory.GetFiles(@"C:\Users\Lecoo\Desktop\Lê Trung Kiên\Kiểm thử nâng cao\Assignment Dự án mẫu\hinhanh");

            foreach (string path in imagePaths)
            {
                try
                {
                    // Load ảnh từ file thực tế
                    Image img = Image.FromFile(path);

                    // Gán key là tên file không có đuôi mở rộng (ví dụ: "avatar1")
                    string key = Path.GetFileNameWithoutExtension(path);

                    // Tránh trùng key
                    if (!imageList1.Images.ContainsKey(key))
                    {
                        imageList1.Images.Add(key, img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                }
            }           
        }
    }
}
