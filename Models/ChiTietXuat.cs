namespace QLHieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietXuat")]
    public partial class ChiTietXuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Required]
        [StringLength(20)]
        public string MaPhieuXuat { get; set; }

        [Required]
        [StringLength(20)]
        public string MaThuoc { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhachHang { get; set; }
    }
}
