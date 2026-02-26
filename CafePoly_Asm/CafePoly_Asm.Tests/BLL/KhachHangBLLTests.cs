using NUnit.Framework;
using BLL;
using DTO;
using System.Data;

namespace CafePoly_Asm.Tests.BLL
{
    [TestFixture]
    public class KhachHangBLL_AttributeTests
    {
        private KhachHangDTO _kh = null!;

        // ================== SETUP ==================
        [SetUp]
        public void SetUp()
        {
            _kh = new KhachHangDTO
            {
                MaKH = 1,
                TenKh = "Khách Test",
                SDT = "0909000000"
            };
        }

        // ================== 1. TESTCASE ==================
        [TestCase(0, "Khách", "0909", "Chưa nhập mã khách hàng")]
        [TestCase(1, "", "0909", "Chưa nhập tên khách hàng")]
        [TestCase(1, "Khách", "", "Chưa nhập SDT khách hàng")]
        public void ThemKhachHang_InputKhongHopLe_TraVeThongBao(
            int maKH, string ten, string sdt, string expected)
        {
            _kh.MaKH = maKH;
            _kh.TenKh = ten;
            _kh.SDT = sdt;

            string result = KhachHangBLL.ThemKhachHang(_kh);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ================== 2. CATEGORY ==================
        [Test]
        [Category("BusinessRule")]
        public void ThemKhachHang_MaKH_Trung_TraVeThongBao()
        {
            _kh.MaKH = 1;
            _kh.TenKh = "Khách Trùng";
            _kh.SDT = "0901234567"; // ⭐ THÊM DÒNG NÀY

            string result = KhachHangBLL.ThemKhachHang(_kh);

            Assert.That(result, Is.EqualTo("Mã khách hàng đã tồn tại"));
        }

        // ================== 3. DESCRIPTION ==================
        [Test]
        [Description("Kiểm tra sửa khách hàng khi MaKH = 0")]
        public void SuaKhachHang_MaKH_Bang0_TraVeThongBao()
        {
            _kh.MaKH = 0;

            string result = KhachHangBLL.SuaKhachHang(_kh);

            Assert.That(result, Is.EqualTo("Vui lòng nhập mã khách hàng"));
        }

        // ================== 4. TIMEOUT ==================
        //[Test]
        //[Timeout(3000)] // 3 giây
        //public void LayDanhSachKhachHang_KhongQua3Giay()
        //{
        //    DataTable dt = KhachHangBLL.LayDanhSachKhachHang();

        //    Assert.That(dt, Is.Not.Null);
        //}

        // ================== 5. IGNORE ==================
        [Test]
        [Ignore("Chức năng tìm kiếm đang hoàn thiện")]
        public void TimKhachHang_ChuaHoanThien()
        {
            DataTable dt = KhachHangBLL.timKhachHangTheoTenHoacSDT("Test");

            Assert.That(dt, Is.Not.Null);
        }

        // ================== TEARDOWN ==================
        [TearDown]
        public void TearDown()
        {
            _kh = null!;
        }
    }
}
