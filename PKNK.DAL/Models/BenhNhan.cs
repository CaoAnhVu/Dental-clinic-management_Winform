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
            TTCanLamSans = new HashSet<TTCanLamSan>();
        }

        [Key]
        public int MaBN { get; set; }

        [Required]
        [StringLength(255)]
        public string TenBN { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        public bool GioiTinh { get; set; }

        public DateTime NgayTao { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? DaThanhToan { get; set; }

        [Column(TypeName = "ntext")]
        public string GhiChu { get; set; }

        [StringLength(10)]
        public string MaTrangThai { get; set; }

        public bool? HuyetApMach { get; set; }

        public bool? DuongHuyet { get; set; }

        public bool? MauKhoDong { get; set; }

        public bool? BenhTimBamSinh { get; set; }

        public bool? ThieuNangTriTue { get; set; }

        [StringLength(255)]
        public string XQuang { get; set; }

        [StringLength(15)]
        public string MaBaoHiem { get; set; }

        [Column(TypeName = "ntext")]
        public string Khac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual TrangThai TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChanDoan> ChanDoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCanLamSan> TTCanLamSans { get; set; }
    }
}
