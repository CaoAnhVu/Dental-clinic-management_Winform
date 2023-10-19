using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class KhachHangService
    {
        public List<BenhNhan> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.BenhNhans.ToList();
        }

        public void Add(BenhNhan bn)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.BenhNhans.Add(bn);
                model.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception("Add(BenhNhan bn)" + ex.Message);
            }
        }

        public void Remove(BenhNhan bn)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.BenhNhans.Remove(bn);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(BenhNhan bn)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.BenhNhans.AddOrUpdate(bn);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public BenhNhan FindById(int id)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.BenhNhans.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BenhNhan> SearchByName(string name)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.BenhNhans.Where(p => p.TenBN == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
