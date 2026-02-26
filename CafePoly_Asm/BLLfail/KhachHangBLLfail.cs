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
            System.Threading.Thread.Sleep(3000); // ❌ quá 2 giây
            return KhachHangDAL.GetAllKhachHang();
        }

        // ================== 2. LỖI VALIDATE ==================
        public static string ThemKhachHang(KhachHangDTO kh)
        {
            // ❌ LỖI: không bắt được MaKH = 0
            if (kh.MaKH < 0)
                return "Chưa nhập mã khách hàng";

            // ❌ LỖI: sai thông báo so với expected
            if (string.IsNullOrEmpty(kh.TenKh))
                return "Thiếu tên KH";

            if (string.IsNullOrEmpty(kh.SDT))
                return "Chưa nhập SDT khách hàng";

            // ================== 3. LỖI BUSINESS RULE ==================
            // ❌ Cố tình bỏ kiểm tra trùng mã
            // if (KhachHangDAL.KiemTraMaTrung(kh.MaKH))
            //     return "Mã khách hàng đã tồn tại";

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
            // ❌ LỖI: không check MaKH = 0
            try
            {
                KhachHangDAL.SuaKhachHang(kh);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa khách hàng : " + ex.Message;
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
