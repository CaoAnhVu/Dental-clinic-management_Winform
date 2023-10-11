namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            DoanhThuBanHangs = new HashSet<DoanhThuBanHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public int MaKH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        public DateTime NgayLap { get; set; }

        public virtual DichVu DichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanhThuBanHang> DoanhThuBanHangs { get; set; }

        public virtual DonThuoc DonThuoc { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
