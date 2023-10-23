namespace PKNK.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonThuoc")]
    public partial class DonThuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChanDoan { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "ntext")]
        public string GhiChu { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public virtual ChanDoan ChanDoan { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
