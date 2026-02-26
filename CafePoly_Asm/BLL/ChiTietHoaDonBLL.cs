using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        // lấy danh sách chi tiết hóa đơn
        public static DataTable LayDanhSachCTHD(string maThe)
        {
            return ChiTietHoaDonDAL.GetAllChiTietHoaDon(maThe);
        }

        // nghiệp vụ thêm 
        public static string ThemHDCT(ChiTietHoaDonDTO cthd)
        {
            if (cthd.MaHD == 0)
                return "Chưa có mã hóa đơn";
            if (cthd.MaDU == 0)
                return "Chưa có mã đồ uống";
            if (cthd.SoLuong == 0)
                return "Chưa nhập số lượng";
            if (cthd.DonGia == 0)
                return "Chưa có đơn giá";           

            try
            {
                ChiTietHoaDonDAL.ThemHDCT(cthd);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm hóa đơn chi tiết: " + ex.Message;
            }
        }
     
        // nghiệp vụ xóa
        public static bool XoaHDCT(int maHD, int maDU)
        {
            return ChiTietHoaDonDAL.XoaHDCT(maHD,maDU);          
        }       
    }
}
