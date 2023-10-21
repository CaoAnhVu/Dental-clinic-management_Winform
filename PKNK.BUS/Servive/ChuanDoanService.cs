using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ChuanDoanService
    {
        public List<ChanDoan> GetAll() {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ChanDoans.ToList();    
        }
        public void Add(ChanDoan cd)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ChanDoans.AddOrUpdate(cd);
            model.SaveChanges();
        }
    }
}
