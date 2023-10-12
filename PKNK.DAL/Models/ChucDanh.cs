namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucDanh")]
    public partial class ChucDanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucDanh()
        {
            BacSis = new HashSet<BacSi>();
        }

        [Key]
        [StringLength(10)]
        public string MaChucDanh { get; set; }

        [Column("ChucDanh")]
        [StringLength(10)]
        public string ChucDanh1 { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BacSi> BacSis { get; set; }
    }
}
