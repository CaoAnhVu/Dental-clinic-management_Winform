namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Luong")]
    public partial class Luong
    {
        [Key]
        [StringLength(10)]
        public string Thang { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongBS1 { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongBS2 { get; set; }

        public int SoNgayNghiBS1 { get; set; }

        public int SoNgayNghiBS2 { get; set; }

        [Column(TypeName = "money")]
        public decimal TruTienBS1 { get; set; }

        [Column(TypeName = "money")]
        public decimal TruTienBS2 { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongThucNhanBS1 { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongThucNhanBS2 { get; set; }

        public virtual ThongKeThang ThongKeThang { get; set; }
    }
}
