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
    public class LoaiDoUongBLL
    {
        // nghiệp vụ loaddata bảng Loại đồ uống
        public static DataTable LayDanhSachLoaiDoUong()
        {
            return LoaiDoUongDAL.GetAllLoaiDoUong();
        }

        // nghiệp vụ thêm 
        public static string ThemLoaiDoUong(LoaiDoUongDTO ldu)
        {
            if (ldu.MaLoai == 0)
                return "Chưa nhập mã Loại đồ uống";

            if (string.IsNullOrEmpty(ldu.TenLoai))
                return "Chưa nhập tên loại đồ uống";

            if (LoaiDoUongDAL.KiemTraMaTrung(ldu.MaLoai))
                return "Mã loại đã tồn tại";

            try
            {
                LoaiDoUongDAL.ThemLoaiDoUong(ldu);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm Loại đồ uóng: " + ex.Message;
            }
        }

        // nghiệp vụ sửa
        public static string SuaLoaiDoUong(LoaiDoUongDTO ldu)
        {
            if(ldu.MaLoai == 0)
                return "Vui lòng nhập mã loại";

            try
            {
                LoaiDoUongDAL.SuaLoaiDoUong(ldu);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi khi sửa loại đồ uóng: " + ex.Message;
            }
        }

        // nghiệp vụ xóa
        public static bool XoaLoaiDoUong(int maLoai)
        {
            return LoaiDoUongDAL.XoaLoaiDoUong(maLoai);
        }

        //nghiệp vụ tìm kiếm theo tên nhân viên
        public static DataTable timLoaiDoUongTheoTen(string ten)
        {
            return LoaiDoUongDAL.TimLoaiDoUongTheoTen(ten);
        }
    }
}
