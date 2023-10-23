using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class XuatNhapService
    {
        public List<DonXuatNhap> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.DonXuatNhaps.ToList();
        }

        public void Add(DonXuatNhap don)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.DonXuatNhaps.Add(don);
            model.SaveChanges();
        }
    }
}
