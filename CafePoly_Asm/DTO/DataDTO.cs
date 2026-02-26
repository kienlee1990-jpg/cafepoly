using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string MatKhau { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int Quyen { get; set; } 
    }


    public class LoaiDoUongDTO
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }

    public class TheLuuDongDTO
    {
        public int MaThe { get; set; }
        public string ChuSoHuu { get; set; }
        public string TrangThai { get; set; }
    }
    public class DoUongDTO
    {
        public int MaDU { get; set; }
        public string TenDU { get; set; }
        public int MaLoai { get; set; }
        public float DonGia { get; set; }
        public string HinhAnh { get; set; }
    }

    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string TenKh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    }

    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public int MaThe { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }

    public class ChiTietHoaDonDTO
    {
        public int MaHD { get; set; }
        public int MaDU { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
