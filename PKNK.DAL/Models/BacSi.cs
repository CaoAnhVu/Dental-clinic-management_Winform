namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacSi")]
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            TTCanLamSangs = new HashSet<TTCanLamSang>();
            TTLamSangs = new HashSet<TTLamSang>();
        }

        [Key]
        [StringLength(10)]
        public string MaBS { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenBacSi { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GioiTinh { get; set; }

        public DateTime NamSinh { get; set; }

        public bool TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCanLamSang> TTCanLamSangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTLamSang> TTLamSangs { get; set; }
    }
}
