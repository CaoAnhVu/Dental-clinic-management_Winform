namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoHiem")]
    public partial class BaoHiem
    {
        [Key]
        [StringLength(10)]
        public string MaBaoHiem { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TenLaBo { get; set; }

        public int MaBN { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
