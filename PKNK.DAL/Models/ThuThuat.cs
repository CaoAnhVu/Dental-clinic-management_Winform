namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuThuat")]
    public partial class ThuThuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuThuat()
        {
            ThongTinLS = new HashSet<ThongTinL>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuThuat { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiThuThuat { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenThuThuat { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string DVT { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        public virtual LoaiThuThuat LoaiThuThuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinL> ThongTinLS { get; set; }
    }
}
