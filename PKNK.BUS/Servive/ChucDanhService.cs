using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ChucDanhService
    {
        public List<ChucDanh> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ChucDanhs.ToList();
        }

        public ChucDanh GetById(string id)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.ChucDanhs.FirstOrDefault(p=> p.MaChucDanh == id);
        }
    }
}
