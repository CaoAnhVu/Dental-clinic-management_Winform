namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThuBanHang")]
    public partial class DoanhThuBanHang
    {
        [Key]
        [StringLength(10)]
        public string Thang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Column(TypeName = "money")]
        public decimal TongDoanhThu { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThongKeThang ThongKeThang { get; set; }
    }
}
