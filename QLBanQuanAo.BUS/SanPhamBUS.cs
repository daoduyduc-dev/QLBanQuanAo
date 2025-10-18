using QLBanQuanAo.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace QLBanQuanAo.BUS
{
    public class SanPhamBUS
    {
        public List<SanPham> LayDanhSachSanPham()
        {
            return new List<SanPham>
            {
                new SanPham { MaSP = 1, TenSanPham = "Áo thun nam", GiaBan = 150000, SoLuongTon = 10, MoTa = "Áo cotton mát", GioiTinh = "Nam", HinhAnh = "ao-thun-nam-the-thao.jpg" },
                new SanPham { MaSP = 2, TenSanPham = "Quần jean nam", GiaBan = 350000, SoLuongTon = 15, MoTa = "Co giãn tốt", GioiTinh = "Nam", HinhAnh = "Images/quan-jean-nam.jpg" },
                new SanPham { MaSP = 3, TenSanPham = "Áo sơ mi nam", GiaBan = 220000, SoLuongTon = 12, MoTa = "Lịch sự", GioiTinh = "Nam", HinhAnh = "Images/ao-so-mi-nam.jpg" },
                new SanPham { MaSP = 4, TenSanPham = "Áo khoác nam", GiaBan = 450000, SoLuongTon = 7, MoTa = "Giữ ấm tốt", GioiTinh = "Nam", HinhAnh = "Images/ao-khoac-nam.jpg" },
                new SanPham { MaSP = 5, TenSanPham = "Quần tây nam", GiaBan = 280000, SoLuongTon = 9, MoTa = "Thanh lịch", GioiTinh = "Nam", HinhAnh = "Images/quan-tay-nam.jpg" },
                new SanPham { MaSP = 6, TenSanPham = "Áo polo nam", GiaBan = 190000, SoLuongTon = 14, MoTa = "Thoáng mát", GioiTinh = "Nam", HinhAnh = "Images/ao-polo-nam.jpg" },
                new SanPham { MaSP = 7, TenSanPham = "Váy nữ", GiaBan = 320000, SoLuongTon = 8, MoTa = "Dễ thương", GioiTinh = "nu", HinhAnh = "Images/vay-nu.jpg" },
                new SanPham { MaSP = 8, TenSanPham = "Áo kiểu nữ", GiaBan = 210000, SoLuongTon = 10, MoTa = "Thời trang", GioiTinh = "nu", HinhAnh = "Images/ao-kieu-nu.jpg" },
                new SanPham { MaSP = 9, TenSanPham = "Quần short nữ", GiaBan = 180000, SoLuongTon = 11, MoTa = "Năng động", GioiTinh = "nu", HinhAnh = "Images/quan-short-nu.jpg" },
                new SanPham { MaSP = 10, TenSanPham = "Áo croptop nữ", GiaBan = 160000, SoLuongTon = 9, MoTa = "Trẻ trung", GioiTinh = "nu", HinhAnh = "Images/ao-croptop-nu.jpg" },
                new SanPham { MaSP = 11, TenSanPham = "Chân váy nữ", GiaBan = 250000, SoLuongTon = 7, MoTa = "Công sở", GioiTinh = "nu", HinhAnh = "Images/chan-vay-nu.jpg" },
                new SanPham { MaSP = 12, TenSanPham = "Áo khoác nữ", GiaBan = 400000, SoLuongTon = 6, MoTa = "Phong cách", GioiTinh = "nu", HinhAnh = "Images/ao-khoac-nu.jpg" }
            };
        }

        // 🔹 Hàm lấy sản phẩm theo mã
        public SanPham LaySanPhamTheoMa(int maSP)
        {
            var danhSach = LayDanhSachSanPham();
            return danhSach.FirstOrDefault(sp => sp.MaSP == maSP);
        }
    }
}
