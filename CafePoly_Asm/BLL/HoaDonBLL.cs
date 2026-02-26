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
    public class HoaDonBLL
    {
        // nghiệp vụ loaddata bảng Hóa đơn
        public static DataTable LayDanhSachHD()
        {
            return HoaDonDAL.GetAllHoaDon();
        }

        // nghiệp vụ thêm 
        public static string ThemHD(HoaDonDTO hd)
        {
            if (hd.MaHD == 0)
                return "Chưa nhập mã hóa đơn";

            if (HoaDonDAL.KiemTraMaTrung(hd.MaHD))
                return "Mã hóa đơn đã tồn tại";

            if (hd.MaNV == 0)
                return "Chưa nhập mã nhân viên";

            if (string.IsNullOrEmpty(hd.TrangThai))
                return "Chưa cập nhật trạng thái hóa đơn";

            if (hd.TongTien == 0)
                return "Chưa nhập tổng tiền";
           
            try
            {
                HoaDonDAL.ThemHD(hd);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm hóa đơn: " + ex.Message;
            }
        }

        // nghiệp vụ sửa
        public static string SuaHD(HoaDonDTO hd)
        {
            if (hd.MaHD == 0)
                return "Vui lòng nhập mã hóa đơn";

            try
            {
                HoaDonDAL.SuaHD(hd);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa hóa đơn: " + ex.Message;
            }
        }

        // nghiệp vụ xóa
        public static bool XoaHD(int maHD)
        {
            return HoaDonDAL.XoaHD(maHD);
        }

        //nghiệp vụ tìm kiếm theo mã hóa đơn
        public static DataTable timHD(int? maHD, string DU, string KH)
        {
            return HoaDonDAL.TimHd(maHD, DU, KH);
        }
    }
}
