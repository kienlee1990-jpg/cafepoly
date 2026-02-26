using NUnit.Framework;
using BLL;
using DTO;
using System.Data;

namespace CafePoly_Asm.Tests.BLL
{
    [TestFixture]
    [Category("TheLuuDongBLL")]
    public class TheLuuDongBLLTests
    {
        // ================== LOAD DANH SÁCH ==================

        [Test]
        [Category("Load")]
        public void LayDanhSachThe_KhongNull()
        {
            DataTable dt = TheLuuDongBLL.LayDanhSachthe();

            Assert.That(dt, Is.Not.Null);
        }

        // ================== LOAD THE THEO TRẠNG THÁI ==================

        [TestCase("")]
        [TestCase("Đang sử dụng")]
        [Category("Load")]
        public void LayDanhSachThe2_TheoTrangThai_KhongNull(string trangThai)
        {
            DataTable dt = TheLuuDongBLL.LayDanhSachThe2(trangThai);

            Assert.That(dt, Is.Not.Null);
        }

        // ================== TEST THÊM THẺ ==================

        [TestCase(0, "Chưa nhập mã thẻ")]
        [Category("Validate")]
        public void ThemThe_MaTheKhongHopLe_TraVeThongBao(int maThe, string expected)
        {
            TheLuuDongDTO the = new TheLuuDongDTO
            {
                MaThe = maThe
            };

            string result = TheLuuDongBLL.ThemThe(the);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ================== TEST SỬA THẺ ==================

        [TestCase(0, "Vui lòng nhập mã thẻ")]
        [Category("Validate")]
        public void SuaThe_MaTheKhongHopLe_TraVeThongBao(int maThe, string expected)
        {
            TheLuuDongDTO the = new TheLuuDongDTO
            {
                MaThe = maThe
            };

            string result = TheLuuDongBLL.SuaThe(the);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ================== TEST XÓA ==================
        // ❌ Bỏ qua vì phụ thuộc DB

        [Test]
        [Category("Database")]
        [Ignore("Bỏ qua test vì phụ thuộc dữ liệu Database")]
        public void XoaThe_GoiHam_XoaThanhCong()
        {
            bool result = TheLuuDongBLL.XoaThe(1);

            Assert.That(result, Is.True);
        }

        // ================== TEST TÌM KIẾM ==================

        [TestCase("Đang sử dụng")]
        [TestCase("Trống")]
        [Category("Search")]
        public void TimKiemTheoTrangThai_KhongNull(string trangThai)
        {
            DataTable dt = TheLuuDongBLL.timKiem(trangThai);

            Assert.That(dt, Is.Not.Null);
        }

        // ================== TEST MỞ / ĐÓNG THẺ ==================
        // ❌ Bỏ qua vì gọi DAL update

        [Test]
        [Category("Update")]
        [Ignore("Bỏ qua vì test này update trạng thái DB")]
        public void MoThe_CapNhatTrangThai()
        {
            TheLuuDongDTO the = new TheLuuDongDTO
            {
                MaThe = 1,
                TrangThai = "Đang sử dụng"
            };

            string result = TheLuuDongBLL.MoThe(the);

            Assert.That(result, Is.EqualTo("Cập nhật trạng thái thành công!"));
        }
    }
}
