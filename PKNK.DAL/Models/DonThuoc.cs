namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonThuoc")]
    public partial class DonThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonThuoc()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
