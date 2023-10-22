using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ChanDoanService
    {
        public List<ChanDoan> GetAll() {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ChanDoans.ToList();    
        }

        public int GetUid()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            int? maxMaChanDoan = model.ChanDoans.Max(p => (int?)p.MaChanDoan);
            if (maxMaChanDoan == null)
            {
                return 1;
            }
            return maxMaChanDoan.Value + 1;
        }
        public void Add(ChanDoan cd)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ChanDoans.AddOrUpdate(cd);
            model.SaveChanges();
        }
    }
}
