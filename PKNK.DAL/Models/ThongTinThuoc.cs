namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinThuoc")]
    public partial class ThongTinThuoc
    {
        [Key]
        [StringLength(10)]
        public string MaThongTinThuoc { get; set; }

        public int MaChuanDoan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }
    }
}
