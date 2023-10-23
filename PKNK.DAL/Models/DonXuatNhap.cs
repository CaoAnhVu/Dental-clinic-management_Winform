namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonXuatNhap")]
    public partial class DonXuatNhap
    {
        [Required]
        [StringLength(255)]
        public string NoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public decimal ThanhTien { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [Key]
        public int MaDonXuatNhap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
