namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangThai")]
    public partial class TrangThai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrangThai()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        [Key]
        [StringLength(10)]
        public string MaTrangThai { get; set; }

        [StringLength(20)]
        public string TenTrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
