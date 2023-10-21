using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class ThuocService
    {
        public List<Thuoc> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.Thuocs.ToList();
        }
        public void AddUpdate(Thuoc thuoc)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.Thuocs.AddOrUpdate(thuoc);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(Thuoc thuoc)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.Thuocs.Add(thuoc);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Romove(Thuoc thuoc)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.Thuocs.Remove(thuoc);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Thuoc> SearchByName(string name)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.Thuocs.Where(p=>p.TenThuoc == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Thuoc SearchById(string id)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.Thuocs.FirstOrDefault(p => p.MaThuoc == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
