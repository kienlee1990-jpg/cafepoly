using DTO;
using System;
using System.Data;

namespace DAL
{
    public class ThongKeDAL
    {
        // =========================
        // 1. Thống kê DOANH THU THEO NGÀY
        // =========================
        public static DataTable GetDTNgay(DateTime ngBD, DateTime ngKT)
        {
            string from = ngBD.ToString("yyyy-MM-dd HH:mm:ss");
            string to = ngKT.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $@"
                SELECT 
                    CONVERT(date, b.NgayLap) AS Ngay,
                    SUM(a.ThanhTien) AS DoanhThu
                FROM ChiTietHoaDon a
                JOIN HoaDon b ON b.MaHD = a.MaHD
                WHERE b.TrangThai <> N'Chưa thanh toán'
                  AND b.NgayLap >= '{from}'
                  AND b.NgayLap <  '{to}'
                GROUP BY CONVERT(date, b.NgayLap)
                ORDER BY Ngay
            ";

            return ConnectSQL.Load(sql);
        }

        // =========================
        // 2. Thống kê DOANH THU THEO NHÂN VIÊN
        // =========================
        public static DataTable GetDTNhanVien(DateTime ngBD, DateTime ngKT)
        {
            string from = ngBD.ToString("yyyy-MM-dd HH:mm:ss");
            string to = ngKT.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $@"
                SELECT 
                    nv.TenNV,
                    SUM(hd.TongTien) AS DoanhThu
                FROM HoaDon hd
                JOIN NhanVien nv ON nv.MaNV = hd.MaNV
                WHERE hd.TrangThai <> N'Chưa thanh toán'
                  AND hd.NgayLap >= '{from}'
                  AND hd.NgayLap <  '{to}'
                GROUP BY nv.TenNV
                ORDER BY DoanhThu DESC
            ";

            return ConnectSQL.Load(sql);
        }

        // =========================
        // 3. Tổng DOANH THU 1 NGÀY
        // =========================
        public static decimal GetDoanhThu(DateTime ngay)
        {
            string from = ngay.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string to = ngay.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $@"
                SELECT ISNULL(SUM(TongTien), 0)
                FROM HoaDon
                WHERE TrangThai <> N'Chưa thanh toán'
                  AND NgayLap >= '{from}'
                  AND NgayLap <  '{to}'
            ";

            return Convert.ToDecimal(ConnectSQL.ExcuteScalar_int(sql));
        }

        // =========================
        // 4. SỐ LƯỢNG KHÁCH HÀNG 1 NGÀY
        // =========================
        public static int GetSLKhachHang(DateTime ngay)
        {
            string from = ngay.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string to = ngay.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $@"
                SELECT COUNT(DISTINCT MaKH)
                FROM HoaDon
                WHERE TrangThai <> N'Chưa thanh toán'
                  AND NgayLap >= '{from}'
                  AND NgayLap <  '{to}'
            ";

            return ConnectSQL.ExcuteScalar_int(sql);
        }
    }
}
