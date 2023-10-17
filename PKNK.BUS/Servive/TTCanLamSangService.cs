using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class TTCanLamSangService
    {
        public List<TTCanLamSan> getAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.TTCanLamSans.ToList();
        }

        public void Add(TTCanLamSan item)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.TTCanLamSans.Add(item);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Add(BenhNhan bn)" + ex.Message);
            }
        }

        public void Remove(TTCanLamSan item)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.TTCanLamSans.Remove(item);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(TTCanLamSan item)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.TTCanLamSans.AddOrUpdate(item);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TTCanLamSan FindByMaBN(int item)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.TTCanLamSans.FirstOrDefault(p => p.BenhNhan.MaBN == item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TTCanLamSan> SearchByName(string name)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.TTCanLamSans.Where(p => p.BenhNhan.TenBN == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
