namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThuThuat")]
    public partial class LoaiThuThuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThuThuat()
        {
            ThongTinLS = new HashSet<ThongTinL>();
            ThuThuats = new HashSet<ThuThuat>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoaiThuThuat { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenLoaiThuThuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinL> ThongTinLS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuThuat> ThuThuats { get; set; }
    }
}
