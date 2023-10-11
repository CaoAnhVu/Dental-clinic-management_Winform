namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DonThuocs = new HashSet<DonThuoc>();
            HoaDons = new HashSet<HoaDon>();
            TTCanLamSangs = new HashSet<TTCanLamSang>();
            TTLamSangs = new HashSet<TTLamSang>();
        }

        [Key]
        public int MaKH { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenKH { get; set; }

        [Column(TypeName = "ntext")]
        public string GioiTinh { get; set; }

        public DateTime? NamSinh { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SDT { get; set; }

        [Column(TypeName = "ntext")]
        public string DiaChi { get; set; }

        public DateTime? NgayKhamDau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCanLamSang> TTCanLamSangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTLamSang> TTLamSangs { get; set; }
    }
}
