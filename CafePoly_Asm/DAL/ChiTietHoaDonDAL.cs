using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        

        
        // nghiệp vụ thêm
        public static void ThemHDCT(ChiTietHoaDonDTO cthd)
        {
            string sql = $@"
            INSERT INTO ChiTietHoaDon (MaHD,MaDU,SoLuong,DonGia)
            VALUES ({cthd.MaHD},{cthd.MaDU},{cthd.SoLuong}, {cthd.DonGia})
        ";
            ConnectSQL.RunQuery(sql);
        }

        // nghiệp vụ xóa
        public static bool XoaHDCT(int maHD, int maDU)
        {
            try
            {
                string sql = $"DELETE FROM ChiTietHoaDon WHERE MaHD = {maHD} and MaDU = {maDU}";

                // Kiểm tra xem  mã hóa đơn có tồn tại không trước khi xóa
                string checkSql = $"SELECT * FROM ChiTietHoaDon WHERE MaHD = '{maHD}' and MaDU ='{maDU}'";
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
        
        // load danh sách hóa đơn
        public static DataTable GetAllChiTietHoaDon(string maThe)
        {
            string strSQL = $@"SELECT c.TenDU,b.SoLuong,b.DonGia,b.ThanhTien FROM dbo.HoaDon a
                               JOIN dbo.ChiTietHoaDon b ON b.MaHD = a.MaHD
                               JOIN dbo.DoUong c ON c.MaDU = b.MaDU
                               WHERE a.TrangThai LIKE N'Chưa thanh toán' AND a.MaThe ='{maThe}'";
            return ConnectSQL.Load(strSQL);
        }
    }
}
