using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class EmployeeService
    {
        // Lấy tất cả bác sĩ
        public List<BacSi> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.BacSis.ToList();
        }

        // Thêm bác sĩ
        public void Add(BacSi bs)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.BacSis.Add(bs);
                model.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception($"Thêm bác sĩ lỗi! msg:{ex.Message}");
            }
        }

        // Sửa bác sĩ
        public void Update(BacSi bs)
        {
            try
            {
                // Sữ dụng PKNK_ContextDB
                using (PKNK_ContextDB model = new PKNK_ContextDB())
                {
                    // Tìm bác sĩ trong danh sách
                    BacSi existingBs  = model.BacSis.Find(bs);
                    // Kiểm tra xem bs có không nếu xong thì set lại value cho bác sĩ
                    if (existingBs != null)
                    {
                        model.Entry(existingBs).CurrentValues.SetValues(bs);
                    }
                    // Lưu
                    model.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Sửa bác sĩ lỗi! msg:{ex.Message}");
            }
        }
        
        // Tìm bác sĩ bằng mã bác sĩ
        public BacSi FindById(string id)
        {
            try
            {
                // Sữ dụng PKNK_ContextDB
                using (PKNK_ContextDB model = new PKNK_ContextDB())
                {
                    return model.BacSis.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Tìm bác sĩ lỗi! msg:{ex.Message}");
            }
            
        }

        // Xóa bác sĩ
        public void Delete(BacSi bs)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.BacSis.Remove(bs);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Xóa bác sĩ lỗi! msg:{ex.Message}");
            }
        }
    }
}
