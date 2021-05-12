namespace QLHieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [Key]
        [StringLength(20)]
        public string MaThuoc { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNhom { get; set; }

        [Required]
        [StringLength(20)]
        public string TenThuoc { get; set; }

        [Required]
        [StringLength(20)]
        public string CongDung { get; set; }

        [Required]
        [StringLength(20)]
        public string ThanhPhan { get; set; }

        [Required]
        [StringLength(20)]
        public string DonViTinh { get; set; }

        [Required]
        [StringLength(20)]
        public string XuatXu { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNCC { get; set; }
    }
}
