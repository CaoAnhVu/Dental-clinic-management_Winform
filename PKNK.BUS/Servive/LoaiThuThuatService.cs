using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class LoaiThuThuatService
    {
        public List<LoaiThuThuat> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.LoaiThuThuats.ToList();
        }
    }
}
