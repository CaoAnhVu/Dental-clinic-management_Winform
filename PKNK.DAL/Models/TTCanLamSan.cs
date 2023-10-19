namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTCanLamSan")]
    public partial class TTCanLamSan
    {
        [Key]
        [StringLength(5)]
        public string MaPhieuKham { get; set; }

        public int? MaBN { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? Gan { get; set; }

        public bool? TieuDuong { get; set; }

        public bool? ThapKhop { get; set; }

        public bool? DiUng { get; set; }

        public bool? TieuHoa { get; set; }

        public bool? ThanKinh { get; set; }

        public bool? HoHap { get; set; }

        public bool? TimMach { get; set; }

        public bool? Than { get; set; }

        public bool? KhopThaiDuongHam { get; set; }

        public bool? DaTungNhoRang { get; set; }

        public bool? DaTungChinhNha { get; set; }

        public bool? DaTungDeoHam { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(255)]
        public string Khac { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
