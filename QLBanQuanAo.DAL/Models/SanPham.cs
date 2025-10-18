namespace QLBanQuanAo.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SanPham")]
    public partial class SanPham
    {
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

        // 👉 Thêm thuộc tính giới tính
        [StringLength(10)]
        public string GioiTinh { get; set; }

        // 👉 Thêm thuộc tính hình ảnh
        [StringLength(255)]
        public string HinhAnh { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
