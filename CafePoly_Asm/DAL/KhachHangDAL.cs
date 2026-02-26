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
    public class KhachHangDAL
    {
        // nghiệp vụ LoadData bảng khách hàng
        public static DataTable GetAllKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            return ConnectSQL.Load(sql);
        }

        // nghiệp vụ thêm 
        public static bool KiemTraMaTrung(int maKH)
        {
            string sql = $"SELECT * FROM KhachHang WHERE MaKH = {maKH}";
            return ConnectSQL.ExcuteReader_bool(sql);
        }

        public static void ThemKhachHang(KhachHangDTO kh)
        {
            string sql = $@"
            INSERT INTO KhachHang (MaKH,TenKH,SDT,DiaChi)
            VALUES ({kh.MaKH},N'{kh.TenKh}',N'{kh.SDT}',N'{kh.DiaChi}')
        ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaKhachHang(KhachHangDTO kh)
        {
            string sql = $@"
            UPDATE KhachHang 
            SET  TenKH = N'{kh.TenKh}',
                 SDT = N'{kh.SDT}',
                 DiaChi = N'{kh.DiaChi}'
            WHERE MaKH = {kh.MaKH}
                ";

            ConnectSQL.RunQuery(sql);
        }


        // nghiệp vụ xóa
        public static bool XoaKhachHang(int maKH)
        {
            try
            {
                string sql = $"DELETE FROM KhachHang WHERE MaKH = {maKH}";

                // Kiểm tra xem  khách hàng có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM KhachHang WHERE MaKH = '{maKH}'";
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

        // Nghiệp vụ tìm kiếm theo tên
        public static DataTable TimDoUongTheoTenHoacSDT(string ten)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string sql = "SELECT * FROM KhachHang WHERE TenKH LIKE @ten OR SDT LIKE @ten";

            using var cnn = ConnectSQL.GetConnection();
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ten", "%" + ten + "%");

            using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
            var dt = new DataTable();

            cnn.Open();
            da.Fill(dt);

            return dt;
        }



    }
}
