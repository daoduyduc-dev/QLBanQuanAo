namespace QLBanQuanAo.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public decimal GiaBan { get; set; }

        public int SoLuongTon { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; } // 👈 Thêm dòng này (Nam/Nu)

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
