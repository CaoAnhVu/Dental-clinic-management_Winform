namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacSi")]
    public partial class BacSi
    {
        [Key]
        [StringLength(10)]
        public string MaBS { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenBacSi { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GioiTinh { get; set; }

        public DateTime NamSinh { get; set; }

        [StringLength(10)]
        public string MaChucDanh { get; set; }

        [StringLength(10)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? SoNgayCong { get; set; }

        public int? SoNgayNghi { get; set; }

        public int? SoGioLamViec { get; set; }

        [Column(TypeName = "money")]
        public decimal? TinhLuong { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public virtual ChucDanh ChucDanh { get; set; }
    }
}
