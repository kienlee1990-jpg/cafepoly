using NUnit.Framework;
using BLL;
using DTO;

namespace CafePoly_Asm.Tests.BLL
{
    [TestFixture]
    [Category("DoUongBLL")]
    public class DoUongBLLTests
    {
        // ================== TEST THÊM ĐỒ UỐNG ==================

        [TestCase(0, "Cà phê", 1, "Chưa nhập mã đồ uống")]
        [TestCase(1, "", 1, "Chưa nhập tên đồ uống")]
        [TestCase(1, "Cà phê", 0, "Chưa nhập mã loại đồ uống")]
        [Category("Validate")]
        public void ThemDoUong_ValidateInput(
            int maDU,
            string tenDU,
            int maLoai,
            string expectedMessage)
        {
            // Arrange
            DoUongDTO du = new DoUongDTO
            {
                MaDU = maDU,
                TenDU = tenDU,
                MaLoai = maLoai
            };

            // Act
            string result = DoUongBLL.ThemDoUong(du);

            // Assert (NUnit 4 style)
            Assert.That(result, Is.EqualTo(expectedMessage));
        }

        // ================== TEST SỬA ĐỒ UỐNG ==================

        [TestCase(0, "Vui lòng nhập mã đồ uống")]
        [Category("Validate")]
        public void SuaDoUong_MaDuKhongHopLe_TraVeThongBao(
            int maDU,
            string expected)
        {
            // Arrange
            DoUongDTO du = new DoUongDTO
            {
                MaDU = maDU,
                TenDU = "Trà sữa",
                MaLoai = 1
            };

            // Act
            string result = DoUongBLL.SuaDoUong(du);

            // Assert (NUnit 4 style)
            Assert.That(result, Is.EqualTo(expected));
        }

        // ================== TEST XÓA ĐỒ UỐNG ==================
        // ❌ Bỏ qua vì phụ thuộc DB

        [Test]
        [Category("Database")]
        [Ignore("Bỏ qua test vì phụ thuộc dữ liệu Database")]
        public void XoaDoUong_GoiHam_XoaThanhCong()
        {
            bool result = DoUongBLL.XoaDoUong(1);

            Assert.That(result, Is.True);
        }

        // ================== TEST TÌM KIẾM ==================
        // ❌ Bỏ qua vì phụ thuộc DB

        [TestCase("Cà")]
        [TestCase("Trà")]
        [Category("Search")]
        [Ignore("Bỏ qua test vì phụ thuộc dữ liệu Database")]
        public void TimDoUongTheoTen_KhongNull(string ten)
        {
            var result = DoUongBLL.timDoUongTheoTen(ten);

            Assert.That(result, Is.Not.Null);
        }
    }
}
