using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TheLuuDongDAL
    {
        // nghiệp vụ LoadData bảng thẻ lưu động
        public static DataTable GetAllTheLuuDong()
        {
            string sql = "SELECT * FROM The";
            return ConnectSQL.Load(sql);
        }

        // dùng hiển thị thẻ lên màn hình chính
        public static DataTable GetTheByTrangThai(string trangThai)
        {
            string query = $"SELECT * FROM The WHERE TrangThai = N'{trangThai}'";
            return ConnectSQL.Load(query);
        }

        // nghiệp vụ thêm 
        public static bool KiemTraMaTrung(int maThe)
        {
            string sql = $"SELECT * FROM The WHERE MaThe = {maThe}";
            return ConnectSQL.ExcuteReader_bool(sql);
        }

        public static void ThemThe(TheLuuDongDTO tld)
        {
            string sql = $@"
            INSERT INTO The (MaThe, ChuSoHuu,TrangThai)
            VALUES ({tld.MaThe}, N'CaphePoly',N'Trống')
            ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaThe(TheLuuDongDTO tld)
        {
            string sql = $@"
            UPDATE The 
            SET ChuSoHuu = N'{tld.ChuSoHuu}',
                TrangThai = N'{tld.TrangThai}'
            WHERE MaThe = {tld.MaThe}
            ";

            ConnectSQL.RunQuery(sql);
        }


        // nghiệp vụ xóa
        public static bool XoaThe(int maThe)
        {
            try
            {
                string sql = $"DELETE FROM The WHERE MaThe = {maThe}";

                // Kiểm tra xem thẻ có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM The WHERE MaThe = '{maThe}'";
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

        // Nghiệp vụ tìm kiếm theo trạng thái thẻ
        public static DataTable TimThe(string trangThai)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string sql = "SELECT * FROM The WHERE Trangthai LIKE @trangThai";

            using var cnn = ConnectSQL.GetConnection();
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@trangThai", "%" + trangThai + "%");

            using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
            var dt = new DataTable();

            cnn.Open();
            da.Fill(dt);

            return dt;
        }

        // đóng mở thẻ
        public static bool UpdateTrangThaiThe(TheLuuDongDTO the)
        {
            try
            {
                string sql = $"UPDATE TheLuuDong SET TrangThai = N'{the.TrangThai}' WHERE MaThe = {the.MaThe}";
                ConnectSQL.RunQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
