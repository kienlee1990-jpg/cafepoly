using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class HoaDonDAL
    {
        // nghiệp vụ LoadData bảng hóa đơn
        public static DataTable GetAllHoaDon()
        {
            string sql = "SELECT * FROM HoaDon";
            return ConnectSQL.Load(sql);
        }

        // nghiệp vụ thêm 
        public static bool KiemTraMaTrung(int maHD)
        {
            string sql = $"SELECT * FROM HoaDon WHERE MaHD = {maHD}";
            return ConnectSQL.ExcuteReader_bool(sql);
        }

        public static void ThemHD(HoaDonDTO hd)
        {
            string sql = $@"
            INSERT INTO HoaDon (MaHD,NgayLap,MaNV,MaKH,MaThe,TongTien,TrangThai)
            VALUES ({hd.MaHD},N'{hd.NgayLap}',{hd.MaNV}, {hd.MaKH},{hd.MaThe},{hd.TongTien},N'{hd.TrangThai}')
        ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaHD(HoaDonDTO hd)
        {
            string sql = $@"
            UPDATE HoaDon 
            SET  NgayLap = N'{hd.NgayLap}',
                 TrangThai = N'{hd.TrangThai}',
                 MaNV = {hd.MaNV},
                 MaKH = {hd.MaKH},
                 MaThe = {hd.MaThe},
                 TongTien = {hd.TongTien}
            WHERE MaHD = {hd.MaHD}
                ";

            ConnectSQL.RunQuery(sql);
        }


        // nghiệp vụ xóa
        public static bool XoaHD(int maHD)
        {
            try
            {
                string sql = $"DELETE FROM HoaDon WHERE MaHD = {maHD}";

                // Kiểm tra xem  hóa đơn có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM HoaDon WHERE MaHD = '{maHD}'";
                bool exists = ConnectSQL.ExcuteReader_bool(checkSql);

                if (!exists)
                    return false;

                ConnectSQL.RunQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Nghiệp vụ tìm kiếm theo mã hóa đơn
        public static DataTable TimHd(int? maHD, string DU, string KH)
        {
            string sql = @"
                            SELECT DISTINCT a.* 
                            FROM dbo.HoaDon a
                            JOIN KhachHang b ON b.MaKH = a.MaKH
                            JOIN dbo.ChiTietHoaDon c ON c.MaHD = a.MaHD
                            JOIN dbo.DoUong d ON d.MaDU = c.MaDU
                            WHERE (@MaHD IS NULL OR a.MaHD = @MaHD)
                                    AND (
                                            b.TenKH LIKE N'%' + @KH + '%' 
                                            OR (TRY_CAST(@KH AS INT) IS NOT NULL AND a.MaKH = TRY_CAST(@KH AS INT)))
              
                                    AND (
                                            d.TenDU LIKE N'%' + @DU + '%' 
                                            OR (TRY_CAST(@DU AS INT) IS NOT NULL AND d.MaDU = TRY_CAST(@DU AS INT)))
              
                        ";

            using (SqlConnection conn = ConnectSQL.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", (object)maHD ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DU", DU ?? string.Empty);
                    cmd.Parameters.AddWithValue("@KH", KH ?? string.Empty);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


    }
}
