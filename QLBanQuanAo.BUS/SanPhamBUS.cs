using QLBanQuanAo.DAL.Models;
using System.Collections.Generic;

namespace QLBanQuanAo.BUS
{
    public class SanPhamBUS
    {
        public List<SanPham> LayTatCaSanPham()
        {
            return new List<SanPham>
            {
                new SanPham { MaSP = 1, TenSanPham = "Áo thun nam", GiaBan = 150000, SoLuongTon = 10, MoTa = "Áo cotton mát", GioiTinh = "Nam" },
                new SanPham { MaSP = 2, TenSanPham = "Quần jean nam", GiaBan = 350000, SoLuongTon = 15, MoTa = "Co giãn tốt", GioiTinh = "Nam" },
                new SanPham { MaSP = 3, TenSanPham = "Áo sơ mi nam", GiaBan = 220000, SoLuongTon = 12, MoTa = "Lịch sự", GioiTinh = "Nam" },
                new SanPham { MaSP = 4, TenSanPham = "Áo khoác nam", GiaBan = 450000, SoLuongTon = 7, MoTa = "Giữ ấm tốt", GioiTinh = "Nam" },
                new SanPham { MaSP = 5, TenSanPham = "Quần tây nam", GiaBan = 280000, SoLuongTon = 9, MoTa = "Thanh lịch", GioiTinh = "Nam" },
                new SanPham { MaSP = 6, TenSanPham = "Áo polo nam", GiaBan = 190000, SoLuongTon = 14, MoTa = "Thoáng mát", GioiTinh = "Nam" },
                new SanPham { MaSP = 7, TenSanPham = "Váy nữ", GiaBan = 320000, SoLuongTon = 8, MoTa = "Dễ thương", GioiTinh = "Nu" },
                new SanPham { MaSP = 8, TenSanPham = "Áo kiểu nữ", GiaBan = 210000, SoLuongTon = 10, MoTa = "Thời trang", GioiTinh = "Nu" },
                new SanPham { MaSP = 9, TenSanPham = "Quần short nữ", GiaBan = 180000, SoLuongTon = 11, MoTa = "Năng động", GioiTinh = "Nu" },
                new SanPham { MaSP = 10, TenSanPham = "Áo croptop nữ", GiaBan = 160000, SoLuongTon = 9, MoTa = "Trẻ trung", GioiTinh = "Nu" },
                new SanPham { MaSP = 11, TenSanPham = "Chân váy nữ", GiaBan = 250000, SoLuongTon = 7, MoTa = "Công sở", GioiTinh = "Nu" },
                new SanPham { MaSP = 12, TenSanPham = "Áo khoác nữ", GiaBan = 400000, SoLuongTon = 6, MoTa = "Phong cách", GioiTinh = "Nu" },
            };
        }

        public SanPham LaySanPhamTheoMa(int maSP)
        {
            return LayTatCaSanPham().Find(sp => sp.MaSP == maSP);
        }
    }
}
