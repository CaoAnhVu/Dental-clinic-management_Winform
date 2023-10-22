using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ThongTinLsServive
    {
        public List<ThongTinL> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ThongTinLS.ToList();
        }

        public List<ThongTinL> FindByMaChuanDoan(int maChuanDoan)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ThongTinLS.Where(p=> p.MaChanDoan == maChuanDoan).ToList();
        }

        public void Add(ThongTinL l)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ThongTinLS.Add(l);
            model.SaveChanges();
        }
    }
}
