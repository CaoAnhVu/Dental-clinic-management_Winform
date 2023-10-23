namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinLS")]
    public partial class ThongTinL
    {
        [Key]
        public int MaThongTinLS { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDungDieuTri { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaThuThuat { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiThuThuat { get; set; }

        public int? SoLuong { get; set; }

        public int? MaChanDoan { get; set; }

        public int? GiamGia { get; set; }

        public virtual ChanDoan ChanDoan { get; set; }

        public virtual LoaiThuThuat LoaiThuThuat { get; set; }

        public virtual ThuThuat ThuThuat { get; set; }
    }
}
