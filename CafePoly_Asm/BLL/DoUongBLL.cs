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
    public class DoUongBLL
    {
        // nghiệp vụ loaddata bảng  đồ uống
        public static DataTable LayDanhSachDoUong()
        {
            return DoUongDAL.GetAllDoUong();
        }

        // nghiệp vụ thêm 
        public static string ThemDoUong(DoUongDTO du)
        {
            if (du.MaDU == 0)
                return "Chưa nhập mã đồ uống";

            if (string.IsNullOrEmpty(du.TenDU))
                return "Chưa nhập tên đồ uống";

            if (du.MaLoai == 0)
                return "Chưa nhập mã loại đồ uống";

            if (DoUongDAL.KiemTraMaTrung(du.MaDU))
                return "Mã đồ uống đã tồn tại";

            try
            {
                DoUongDAL.ThemDoUong(du);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm đồ uóng: " + ex.Message;
            }
        }

        // nghiệp vụ sửa
        public static string SuaDoUong(DoUongDTO du)
        {
            if (du.MaDU == 0)
                return "Vui lòng nhập mã đồ uống";

            try
            {
                DoUongDAL.SuaDoUong(du);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa đồ uóng: " + ex.Message;
            }
        }

        // nghiệp vụ xóa
        public static bool XoaDoUong(int maDU)
        {
            return DoUongDAL.XoaDoUong(maDU);
        }

        //nghiệp vụ tìm kiếm theo tên nhân viên
        public static DataTable timDoUongTheoTen(string ten)
        {
            return DoUongDAL.TimDoUongTheoTen(ten);
        }
    }
}
