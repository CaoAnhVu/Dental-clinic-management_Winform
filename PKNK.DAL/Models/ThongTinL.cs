namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinLS")]
    public partial class ThongTinL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinL()
        {
            ChanDoans = new HashSet<ChanDoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaThongTinLS { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChanDoan { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string NoiDungDieuTri { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaThuThuat { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiThuThuat { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChanDoan> ChanDoans { get; set; }

        public virtual LoaiThuThuat LoaiThuThuat { get; set; }

        public virtual ThuThuat ThuThuat { get; set; }
    }
}
