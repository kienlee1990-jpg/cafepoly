using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        // ================== 1. LỖI TIMEOUT ==================
        // Cố tình làm chậm để test [Timeout] FAIL
        public static DataTable LayDanhSachKhachHang()
        {
            System.Threading.Thread.Sleep(2000); // ❌ quá 2 giây
            return KhachHangDAL.GetAllKhachHang();
        }

        // ================== 2. LỖI VALIDATE ==================
        public static string ThemKhachHang(KhachHangDTO kh)
        {
            // ❌ LỖI: không bắt được MaKH = 0
            if (kh.MaKH <= 0)
                return "Chưa nhập mã khách hàng";

            // ❌ LỖI: sai thông báo so với expected
            if (string.IsNullOrEmpty(kh.TenKh))
                return "Chưa nhập tên khách hàng";

            if (string.IsNullOrEmpty(kh.SDT))
                return "Chưa nhập SDT khách hàng";

            // ================== 3. LỖI BUSINESS RULE ==================
            // ❌ Cố tình bỏ kiểm tra trùng mã
             if (KhachHangDAL.KiemTraMaTrung(kh.MaKH))
                 return "Mã khách hàng đã tồn tại";

            try
            {
                KhachHangDAL.ThemKhachHang(kh);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm khách hàng: " + ex.Message;
            }
        }

        // ================== 4. LỖI SỬA KH ==================
        public static string SuaKhachHang(KhachHangDTO kh)
        {
            // ✅ validate mã khách hàng
            if (kh.MaKH <= 0)
                return "Vui lòng nhập mã khách hàng";

            try
            {
                KhachHangDAL.SuaKhachHang(kh);
                return "OK";
            }
            catch (Exception)
            {
                return "Lỗi khi sửa khách hàng";
            }
        }

        // ================== 5. XÓA ==================
        public static bool XoaKhachHang(int maKH)
        {
            return KhachHangDAL.XoaKhachHang(maKH);
        }

        // ================== 6. TÌM KIẾM ==================
        public static DataTable timKhachHangTheoTenHoacSDT(string tukhoa)
        {
            return KhachHangDAL.TimDoUongTheoTenHoacSDT(tukhoa);
        }
    }
}
