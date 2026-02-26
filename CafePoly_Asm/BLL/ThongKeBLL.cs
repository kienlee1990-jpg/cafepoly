using System;
using System.Data;
using DAL;

namespace BLL
{
    public class ThongKeBLL
    {
        // Doanh thu theo ngày
        public static DataTable ThongKeDTNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return ThongKeDAL.GetDTNgay(ngayBatDau, ngayKetThuc);
        }

        // Doanh thu theo nhân viên
        public static DataTable ThongKeDTNV(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return ThongKeDAL.GetDTNhanVien(ngayBatDau, ngayKetThuc);
        }

        // Tổng doanh thu 1 ngày
        public static decimal GetDoanhThu(DateTime ngay)
        {
            return ThongKeDAL.GetDoanhThu(ngay);
        }

        // Số lượng khách hàng 1 ngày
        public static int GetKhachHang(DateTime ngay)
        {
            return ThongKeDAL.GetSLKhachHang(ngay);
        }
    }
}
