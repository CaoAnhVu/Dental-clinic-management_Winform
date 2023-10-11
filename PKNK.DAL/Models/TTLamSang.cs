namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTLamSang")]
    public partial class TTLamSang
    {
        [Key]
        [StringLength(10)]
        public string MaTTLamSang { get; set; }

        public int MaKH { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string NoiDung { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string ChanDoan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaBS { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTTCanLamSang { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual TTCanLamSang TTCanLamSang { get; set; }
    }
}
