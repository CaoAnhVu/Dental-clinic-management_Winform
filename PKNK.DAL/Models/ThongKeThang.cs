namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongKeThang")]
    public partial class ThongKeThang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongKeThang()
        {
            ThongKeNams = new HashSet<ThongKeNam>();
        }

        [Key]
        [StringLength(10)]
        public string Thang { get; set; }

        [Column(TypeName = "money")]
        public decimal DoanhThu { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongNV { get; set; }

        [Column(TypeName = "money")]
        public decimal DoanhThuBanHang { get; set; }

        [Column(TypeName = "money")]
        public decimal ChiPhi { get; set; }

        public virtual ChiPhiVatLieu ChiPhiVatLieu { get; set; }

        public virtual DoanhThuBanHang DoanhThuBanHang1 { get; set; }

        public virtual Luong Luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongKeNam> ThongKeNams { get; set; }
    }
}
