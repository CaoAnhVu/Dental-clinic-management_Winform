namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            DonThuocs = new HashSet<DonThuoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenThuoc { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string DVT { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }
    }
}
