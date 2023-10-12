using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PKNK.DAL.Models
{
    public partial class PKNK_ContextDB : DbContext
    {
        public PKNK_ContextDB()
            : base("name=PKNK_ContextDB")
        {
        }

        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<BacSi> BacSis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.DienThoai)
                .IsFixedLength();

            modelBuilder.Entity<BacSi>()
                .Property(e => e.TinhLuong)
                .HasPrecision(19, 4);
        }
    }
}
