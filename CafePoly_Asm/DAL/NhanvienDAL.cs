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
    public class NhanvienDAL
    {
        public static bool KiemTraDangNhap(string maNV, string matKhau)
        {
            using (SqlConnection conn = ConnectSQL.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @maNV AND MatKhau = @matKhau";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);

                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        // nghiệp vụ LoadData bảng NhanVien
        public static DataTable GetAllNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return ConnectSQL.Load(sql);
        }


        // nghiệp vụ thêm nhân viên
        public static bool KiemTraMaTrung(int maNV)
        {
            string sql = $"SELECT * FROM NhanVien WHERE MaNV = '{maNV}'";
            return ConnectSQL.ExcuteReader_bool(sql);
        }
        
        public static void ThemNhanVien(NhanVienDTO nv)
        {
            string sql = $@"
            INSERT INTO NhanVien (MaNV, TenNV, MatKhau, SDT, DiaChi)
            VALUES ('{nv.MaNV}', N'{nv.TenNV}', N'{nv.MatKhau}', '{nv.SDT}', N'{nv.DiaChi}')
        ";
            ConnectSQL.RunQuery(sql);
        }

        // Nghiệp vụ sửa
        public static void SuaNhanVien(NhanVienDTO nv)
        {
            string sql = $@"
                UPDATE  NhanVien 
                 SET    TenNV = N'{nv.TenNV}', 
                        MatKhau = N'{nv.MatKhau}', 
                        SDT = '{nv.SDT}', 
                        DiaChi = N'{nv.DiaChi}'
                WHERE MaNV = '{nv.MaNV}'
                ";

            ConnectSQL.RunQuery(sql);
        }

        // nghiệp vụ xóa
        public static bool XoaNhanVien(string maNV)
        {
            try
            {
                string sql = $"DELETE FROM NhanVien WHERE MaNV = '{maNV}'";

                // Kiểm tra xem nhân viên có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM NhanVien WHERE MaNV = '{maNV}'";
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
        public static DataTable TimNhanVienTheoTen(string ten)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE @ten";

            using var cnn = ConnectSQL.GetConnection();
            using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ten", "%" + ten + "%");

            using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
            var dt = new DataTable();

            cnn.Open();
            da.Fill(dt);

            return dt;
        }

        // lấy tên nhân viên
        public static string GetTenNhanVienByMaNV(int maNV)
        {
            string sql = $"SELECT TenNV FROM NhanVien WHERE MaNV = {maNV}";
            return ConnectSQL.ExcuteScalar_string(sql);
        }

        // đổi mật khẩu

        public static bool DoiMatKhau(int maNV, string matKhauMoi)
        {
            try
            {
                string sql = $"UPDATE NhanVien SET MatKhau = '{matKhauMoi}' WHERE MaNV = {maNV}";
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

