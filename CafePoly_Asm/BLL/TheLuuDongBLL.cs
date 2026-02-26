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
    public class TheLuuDongBLL
    {
        // nghiệp vụ loaddata bảng thẻ lưu động
        public static DataTable LayDanhSachthe()
        {
            return TheLuuDongDAL.GetAllTheLuuDong();
        }

        // load khi thêm trạng thái thẻ
        public static DataTable LayDanhSachThe2(string trangThai = "")
        {
            if (string.IsNullOrEmpty(trangThai))
                return TheLuuDongDAL.GetAllTheLuuDong();
            else
                return TheLuuDongDAL.GetTheByTrangThai(trangThai);
        }

        // nghiệp vụ thêm 
        public static string ThemThe(TheLuuDongDTO tld)
        {
            if (tld.MaThe == 0)
                return "Chưa nhập mã thẻ";

            try
            {
                TheLuuDongDAL.ThemThe(tld);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm thẻ " + ex.Message;
            }
        }

        // nghiệp vụ sửa
        public static string SuaThe(TheLuuDongDTO tld)
        {
            if (tld.MaThe == 0)
                return "Vui lòng nhập mã thẻ";

            try
            {
                TheLuuDongDAL.SuaThe(tld);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa thẻ " + ex.Message;
            }
        }

        // nghiệp vụ xóa
        public static bool XoaThe(int maThe)
        {
            return TheLuuDongDAL.XoaThe(maThe);
        }

        //nghiệp vụ tìm kiếm theo trạng thái thẻ
        public static DataTable timKiem(string trangThai)
        {
            return TheLuuDongDAL.TimThe(trangThai);
        }

        // đóng mở thẻ
        public static string MoThe(TheLuuDongDTO the)
        {
            bool kq = TheLuuDongDAL.UpdateTrangThaiThe(the);
            return kq ? "Cập nhật trạng thái thành công!" : "Cập nhật thất bại!";
        }
    }
}
