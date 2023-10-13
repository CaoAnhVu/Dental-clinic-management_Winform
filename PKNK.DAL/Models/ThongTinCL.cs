namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinCLS")]
    public partial class ThongTinCL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinCL()
        {
            ChanDoans = new HashSet<ChanDoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaThongTinCLS { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCLS { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChanDoan> ChanDoans { get; set; }

        public virtual CL CL { get; set; }
    }
}
