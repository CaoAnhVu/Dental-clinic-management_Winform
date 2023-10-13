namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            BaoHiems = new HashSet<BaoHiem>();
            ChanDoans = new HashSet<ChanDoan>();
        }

        [Key]
        public int MaBN { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenBN { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SDT { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GioiTinh { get; set; }

        public int Tuổi { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string DiaChi { get; set; }

        public DateTime NgayTao { get; set; }

        [StringLength(2)]
        public string NhomMau { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? DaThanhToan { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienNo { get; set; }

        [Column(TypeName = "ntext")]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChanDoan> ChanDoans { get; set; }
    }
}
