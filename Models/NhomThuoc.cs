namespace QLHieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomThuoc")]
    public partial class NhomThuoc
    {
        [Key]
        [StringLength(20)]
        public string MaNhom { get; set; }

        [Required]
        [StringLength(20)]
        public string TenNhom { get; set; }
    }
}
