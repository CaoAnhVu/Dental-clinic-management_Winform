using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class NhanVienService
    {
        // Lấy tất cả bác sĩ
        public List<NhanVien> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.NhanViens.ToList();
        }

        // Thêm bác sĩ
        public void Add(NhanVien bs)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.NhanViens.Add(bs);
                model.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception($"Thêm nhân viên lỗi! msg:{ex.Message}");
            }
        }

        // Sửa bác sĩ
        public void Update(NhanVien bs)
        {
            try
            {
                // Sữ dụng PKNK_ContextDB
                using (PKNK_ContextDB model = new PKNK_ContextDB())
                {
                    model.NhanViens.AddOrUpdate(bs);
                    model.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Sửa bác sĩ lỗi! msg:{ex.Message}");
            }
        }
        
        // Tìm bác sĩ bằng mã bác sĩ
        public NhanVien FindById(string id)
        {
            try
            {
                // Sữ dụng PKNK_ContextDB
                using (PKNK_ContextDB model = new PKNK_ContextDB())
                {
                    return model.NhanViens.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Tìm bác sĩ lỗi! msg:{ex.Message}");
            }
        }

        public List<NhanVien> SearchByName(string name)
        {
            try
            {
                // Sữ dụng PKNK_ContextDB
                PKNK_ContextDB model = new PKNK_ContextDB();
                return model.NhanViens.Where(p=>p.TenNhanVien.ToLower().Contains(name.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Tìm bác sĩ lỗi! msg:{ex.Message}");
            }
        }

        // Xóa bác sĩ
        public void Delete(NhanVien bs)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                NhanVien tmp = model.NhanViens.Find(bs.MaNhanVien);
                model.NhanViens.Remove(tmp);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Xóa bác sĩ lỗi! msg:{ex.Message}");
            }
        }
    }
}
