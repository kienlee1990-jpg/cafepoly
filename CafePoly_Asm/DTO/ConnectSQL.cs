using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DTO
{
    public class ConnectSQL
    {
        // Sửa chuỗi kết nối để thay đổi máy chủ và cơ sở dữ liệu
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-5OFV1UQ;Initial Catalog=cafepoly;Integrated Security=True;Trust Server Certificate=True");
        }
        public static SqlConnection cnn;
        // Hàm mở kết nối
        public static void OpenConnection()
        {
            cnn = GetConnection();
            cnn.Open();
        }

        // Hàm đóng kết nối
        public static   void CloseConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

        }

        // Hàm chạy lệnh sql lấy dữ liệu data query
        public static DataTable Load(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Hàm chạy lệnh sql Thêm, Xóa , Sửa non query
        public static string RunQuery(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            CloseConnection();
            return "Success";
        }

        // Phương thức kiểm tra sự tồn tại của dữ liệu
        public static bool ExcuteReader_bool(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }

        }

        // Phương thức trả về một giá trị nào đó mà ta tìm
        public static string ExcuteScalar_string(string sql)
        {
            //OpenConnection();
            //SqlCommand cmd = cnn.CreateCommand();
            //cmd.CommandText = sql;
            //return cmd.ExecuteScalar().ToString();
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            object result = cmd.ExecuteScalar();

            return result != null ? result.ToString() : string.Empty;
        }

        // Phương thức trả về int từ câu lệnh SELECT
        public static int ExcuteScalar_int(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            object result = cmd.ExecuteScalar();
            CloseConnection();
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }

        // Lấy mã hóa đơn mới
        public static int LayMaHDMoi()
        {
            string sql = "SELECT ISNULL(MAX(MaHD), 0) + 1 FROM HoaDon";
            return ExcuteScalar_int(sql);
        }
    }
}