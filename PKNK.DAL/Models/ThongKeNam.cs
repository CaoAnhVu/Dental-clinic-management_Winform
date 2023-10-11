namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongKeNam")]
    public partial class ThongKeNam
    {
        [Key]
        [StringLength(10)]
        public string Nam { get; set; }

        [Required]
        [StringLength(10)]
        public string Thang { get; set; }

        [Column(TypeName = "money")]
        public decimal DoanhThu { get; set; }

        public virtual ThongKeThang ThongKeThang { get; set; }
    }
}
