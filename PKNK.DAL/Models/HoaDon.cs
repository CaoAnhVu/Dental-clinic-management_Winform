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
            DoanhThus = new HashSet<DoanhThu>();
        }

        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChanDoan { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        public DateTime Ngay { get; set; }

        public virtual ChanDoan ChanDoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanhThu> DoanhThus { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
