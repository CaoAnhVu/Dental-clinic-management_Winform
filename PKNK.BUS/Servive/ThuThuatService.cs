using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ThuThuatService
    {
        public List<ThuThuat> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ThuThuats.ToList();
        }

        public List<ThuThuat> FindTypeById(string MaLoaiTT)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ThuThuats.Where(p=> p.MaLoaiThuThuat == MaLoaiTT).ToList();
        }

        public void AddUpdate(ThuThuat tt)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ThuThuats.AddOrUpdate(tt);
        }

        public void Romove(ThuThuat tt)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.ThuThuats.Remove(tt);
        }
    }
}