namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonNhapHang")]
    public partial class DonNhapHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDonNhap { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "ntext")]
        public string NoiDung { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "ntext")]
        public string DVTinh { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Ngay { get; set; }

        public virtual DonXuatHang DonXuatHang { get; set; }
    }
}
