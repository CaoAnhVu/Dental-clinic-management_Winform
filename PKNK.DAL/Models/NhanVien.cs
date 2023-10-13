namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChucDanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ChucDanh ChucDanh { get; set; }
    }
}
