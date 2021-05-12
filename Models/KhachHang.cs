namespace QLHieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(20)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(20)]
        public string TenKhachHang { get; set; }

        [Required]
        [StringLength(20)]
        public string SoDienThoai { get; set; }
    }
}
