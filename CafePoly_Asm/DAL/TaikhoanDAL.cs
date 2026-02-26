using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class TaikhoanDAL
    {
        public static bool KiemTraMatKhau(int maNV, string matKhauCu)
        {
            string sql = "SELECT 1 FROM NhanVien WHERE MaNV = @maNV AND MatKhau = @matKhau";
            using (SqlConnection conn = ConnectSQL.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@matKhau", matKhauCu);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public static bool DoiMatKhau(int maNV, string matKhauMoi)
        {
            string sql = "UPDATE NhanVien SET MatKhau = @matKhauMoi WHERE MaNV = @maNV";
            using (SqlConnection conn = ConnectSQL.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@matKhauMoi", matKhauMoi);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
