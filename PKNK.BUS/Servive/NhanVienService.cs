﻿using PKNK.DAL.Models;
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
                    // Tìm bác sĩ trong danh sách
                    NhanVien existingBs  = model.NhanViens.Find(bs);
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

        // Xóa bác sĩ
        public void Delete(NhanVien bs)
        {
            try
            {
                PKNK_ContextDB model = new PKNK_ContextDB();
                model.NhanViens.Remove(bs);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Xóa bác sĩ lỗi! msg:{ex.Message}");
            }
        }

        // Generate UID MaNhanVien trong DB
        //private string GenerateUniqueMaNhanVien()
        //{
        //    using (PKNK_ContextDB db = new YourDbContext())
        //    {
        //        var lastNhanVien = db.NhanViens.OrderByDescending(nv => nv.Id).FirstOrDefault();

        //        if (lastNhanVien != null)
        //        {
        //            int lastId = lastNhanVien.Id;
        //            // Extract the numeric part of MaNhanVien and increment it
        //            int newId = lastId + 1;
        //            return "NV" + newId.ToString("D3");
        //        }
        //        else
        //        {
        //            return "NV001"; // If there are no existing records
        //        }
        //    }
        //}
    }
}
