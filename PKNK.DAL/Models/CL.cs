namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLS")]
    public partial class CL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL()
        {
            ThongTinCLS = new HashSet<ThongTinCL>();
        }

        [Key]
        [StringLength(10)]
        public string MaCLS { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenCLS { get; set; }

        [Column(TypeName = "ntext")]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinCL> ThongTinCLS { get; set; }
    }
}
