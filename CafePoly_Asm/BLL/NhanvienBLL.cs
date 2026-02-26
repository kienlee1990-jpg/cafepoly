using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhanvienBLL
    {
        

        public static bool DangNhap(string maNV, string matKhau)
        {
            return NhanvienDAL.KiemTraDangNhap(maNV, matKhau);
        }

        // nghiệp vụ loaddata
        public static DataTable LayDanhSachNhanVien()
        {
            return NhanvienDAL.GetAllNhanVien();
        }

        // nghiệp vụ thêm nhân viên
        public static string ThemNhanVien(NhanVienDTO nv)
        {
            if (nv.MaNV == 0)
                return "Chưa nhập mã nhân viên uống";

            if (string.IsNullOrEmpty(nv.MatKhau))
                return "Chưa nhập mật khẩu";

            if (NhanvienDAL.KiemTraMaTrung(nv.MaNV))
                return "Mã nhân viên đã tồn tại";

            try
            {
                NhanvienDAL.ThemNhanVien(nv);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm nhân viên: " + ex.Message;
            }
        }

        // nghiệp vụ sửa
        public static string SuaNhanVien(NhanVienDTO nv)
        {
            if (nv.MaNV == 0)
                return "Vui lòng nhập mã nhân viên";

            try
            {
                NhanvienDAL.SuaNhanVien(nv);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa nhân viên: " + ex.Message;
            }
        }

        // nghiệp vụ xóa
        public static bool XoaNhanVien(string maNV)
        {
            return NhanvienDAL.XoaNhanVien(maNV);
        }

        //nghiệp vụ tìm kiếm theo tên nhân viên
        public static DataTable TimNhanVienTheoTen(string ten)
        {
            return NhanvienDAL.TimNhanVienTheoTen(ten);
        }

        // lấy tên nhân viên
        public static string LayTenNhanVien(int maNV)
        {
            return NhanvienDAL.GetTenNhanVienByMaNV(maNV);
        }

        // dùng đổi mật khẩu
        public static bool DoiMatKhau(int maNV, string matKhauMoi)
        {
            return NhanvienDAL.DoiMatKhau(maNV, matKhauMoi);
        }

    }
}
