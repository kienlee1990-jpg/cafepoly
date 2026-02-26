using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TaikhoanBLL
    {
        public static string DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi, string matKhauLai)
        {
            if (matKhauMoi != matKhauLai)
                return "Mật khẩu mới không khớp!";

            if (!int.TryParse(tenDangNhap, out int maNV))
                return "Mã nhân viên không hợp lệ!";

            if (!TaikhoanDAL.KiemTraMatKhau(maNV, matKhauCu))
                return "Mật khẩu cũ không đúng!";

            bool doiThanhCong = TaikhoanDAL.DoiMatKhau(maNV, matKhauMoi);
            return doiThanhCong ? "Đổi mật khẩu thành công!" : "Đổi mật khẩu thất bại!";
        }

    }
}
