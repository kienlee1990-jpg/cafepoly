using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DoUongDAL
    {
        // nghiệp vụ LoadData bảng DoUong
        public static DataTable GetAllDoUong()
        {
            string sql = "SELECT * FROM DoUong";
            return ConnectSQL.Load(sql);
        }

        // nghiệp vụ thêm 
        public static bool KiemTraMaTrung(int maDU)
        {
            string sql = $"SELECT * FROM DoUong WHERE MaDU = {maDU}";
            return ConnectSQL.ExcuteReader_bool(sql);
        }

        public static void ThemDoUong(DoUongDTO du)
        {
            string sql = $@"
            INSERT INTO DoUong (MaDU,TenDU,MaLoai,DonGia,HinhAnh)
            VALUES ({du.MaDU},N'{du.TenDU}',{du.MaLoai}, {du.DonGia},N'{du.HinhAnh}')
        ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaDoUong(DoUongDTO du)
        {
            string sql = $@"
            UPDATE DoUong 
            SET  TenDU = N'{du.TenDU}',
                 MaLoai={du.MaLoai},
                 HinhAnh = N'{du.HinhAnh}',
                 DonGia = {du.DonGia}
            WHERE MaDU = {du.MaDU}
                ";

            ConnectSQL.RunQuery(sql);
        }


        // nghiệp vụ xóa
        public static bool XoaDoUong(int maDU)
        {
            try
            {
                string sql = $"DELETE FROM DoUong WHERE MaDU = {maDU}";

                // Kiểm tra xem  đồ uống có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM DoUong WHERE MaDU = '{maDU}'";
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
        public static DataTable TimDoUongTheoTen(string ten)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string sql = "SELECT * FROM DoUong WHERE TenDU LIKE @ten";

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
