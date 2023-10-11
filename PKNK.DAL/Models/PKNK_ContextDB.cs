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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
