using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiDoUongDAL
    {
        // nghiệp vụ LoadData bảng LoaiDoUong
        public static DataTable GetAllLoaiDoUong()
        {
            string sql = "SELECT * FROM LoaiDoUong";
            return ConnectSQL.Load(sql);
        }

        // nghiệp vụ thêm 
        public static bool KiemTraMaTrung(int maLoai)
        {
            string sql = $"SELECT * FROM LoaiDoUong WHERE MaLoai = {maLoai}";
            return ConnectSQL.ExcuteReader_bool(sql);
        }

        public static void ThemLoaiDoUong(LoaiDoUongDTO ldu)
        {
            string sql = $@"
            INSERT INTO LoaiDoUong (MaLoai, TenLoai)
            VALUES ({ldu.MaLoai}, N'{ldu.TenLoai}')
        ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaLoaiDoUong(LoaiDoUongDTO ldu)
        {
            string sql = $@"
            UPDATE LoaiDoUong 
            SET TenLoai = N'{ldu.TenLoai}'
            WHERE MaLoai = {ldu.MaLoai}
                ";

            ConnectSQL.RunQuery(sql);
        }


        // nghiệp vụ xóa
        public static bool XoaLoaiDoUong(int maLoai)
        {
            try
            {
                string sql = $"DELETE FROM LoaiDoUong WHERE MaLoai = {maLoai}";

                // Kiểm tra xem loại đồ uống có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM LoaiDoUong WHERE MaLoai = '{maLoai}'";
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
        public static DataTable TimLoaiDoUongTheoTen(string ten)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string sql = "SELECT * FROM LoaiDoUong WHERE TenLoai LIKE @ten";

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
