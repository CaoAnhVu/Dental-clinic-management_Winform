namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTCanLamSang")]
    public partial class TTCanLamSang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCanLamSang()
        {
            TTLamSangs = new HashSet<TTLamSang>();
        }

        [Key]
        [StringLength(10)]
        public string MaTTCanLamSang { get; set; }

        public int MaKH { get; set; }

        public bool HuyetAp { get; set; }

        public bool MachDuongHuyet { get; set; }

        [Column("MauKhoDong(TS-TC)")]
        public bool MauKhoDong_TS_TC_ { get; set; }

        public bool TimBamSinh { get; set; }

        public bool ThieuNangTriTue { get; set; }

        [Column("Phim X-Quang", TypeName = "ntext")]
        [Required]
        public string Phim_X_Quang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaBS { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTLamSang> TTLamSangs { get; set; }
    }
}
