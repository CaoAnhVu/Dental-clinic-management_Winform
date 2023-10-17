namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChanDoan")]
    public partial class ChanDoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChanDoan()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        [StringLength(10)]
        public string MaChanDoan { get; set; }

        public int MaBN { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThongTinLS { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ThongTinL ThongTinL { get; set; }
    }
}
