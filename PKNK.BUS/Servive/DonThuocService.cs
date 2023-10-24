using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class DonThuocService
    {
        public List<DonThuoc> getAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.DonThuocs.ToList();
        }
        public List<DonThuoc> FindByMaChuanDoan(int maChuanDoan)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.DonThuocs.Where(p => p.MaChanDoan == maChuanDoan).ToList();
        }

        public decimal TongTienByMaChuanDoan(int maChuanDoan)
        {
            decimal res = 0;
            List<DonThuoc> donThuocs = FindByMaChuanDoan(maChuanDoan);
            foreach (var i in donThuocs)
            {
                res += i.ThanhTien;
            }
            return res;
        }

        public void Add(DonThuoc donThuoc)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.DonThuocs.Add(donThuoc);
            model.SaveChanges();
        }
    }
}
