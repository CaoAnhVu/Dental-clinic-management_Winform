using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class TTLamSanServive
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

        public decimal TongTienByMaChuanDoan(int maChuanDoan)
        {
            decimal res = 0;
            List<ThongTinL> thongTinLs = FindByMaChuanDoan(maChuanDoan);
            foreach (var i in thongTinLs)
            {
                res += i.ThanhTien;
            }
            return res;
        }

        public void Add(ThongTinL l)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ThongTinLS.Add(l);
            model.SaveChanges();
        }
    }
}
