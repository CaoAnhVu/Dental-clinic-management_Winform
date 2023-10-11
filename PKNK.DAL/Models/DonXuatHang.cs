namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonXuatHang")]
    public partial class DonXuatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonXuatHang()
        {
            ChiPhiVatLieux = new HashSet<ChiPhiVatLieu>();
            DonNhapHangs = new HashSet<DonNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonXuat { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDonNhap { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string NoiDung { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        public DateTime Ngay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiPhiVatLieu> ChiPhiVatLieux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }
    }
}
