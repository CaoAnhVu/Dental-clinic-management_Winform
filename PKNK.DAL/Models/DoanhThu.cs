namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        [Key]
        [StringLength(10)]
        public string MaDoanhThu { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        public DateTime Ngay { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
