namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiPhiVatLieu")]
    public partial class ChiPhiVatLieu
    {
        [Key]
        [StringLength(10)]
        public string Thang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDonXuat { get; set; }

        [Column(TypeName = "money")]
        public decimal ChiPhi { get; set; }

        public virtual DonXuatHang DonXuatHang { get; set; }

        public virtual ThongKeThang ThongKeThang { get; set; }
    }
}
