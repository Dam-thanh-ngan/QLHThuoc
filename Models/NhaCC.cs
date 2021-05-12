namespace QLHieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCC")]
    public partial class NhaCC
    {
        [Key]
        [StringLength(20)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string TenNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string SoDienThoai { get; set; }
    }
}
