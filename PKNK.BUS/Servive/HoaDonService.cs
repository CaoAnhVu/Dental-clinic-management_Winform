using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class HoaDonService
    {
        public List<HoaDon> GetAll()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            return model.HoaDons.ToList();
        }

        public int[] GetDoanhThuThang()
        {
            PKNK_ContextDB model = new PKNK_ContextDB();

            int currentYear = DateTime.Now.Year;
            int[] doanhThuThang = new int[12];

            for (int month = 1; month <= 12; month++)
            {
                DateTime startOfMonth = new DateTime(currentYear, month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                // tổng doanh thu trong tháng
                decimal? totalRevenue = model.HoaDons
                    .Where(h => h.Ngay >= startOfMonth && h.Ngay <= endOfMonth)
                    .Sum(h => (decimal?)h.ThanhTien); // Ép kiểu decimal?

                // Kiểm tra giá trị null
                if (totalRevenue.HasValue)
                {
                    doanhThuThang[month - 1] = (int)totalRevenue.Value;
                }
                else
                {
                    doanhThuThang[month - 1] = 0;
                }
            }
            return doanhThuThang;
        }

        public decimal GetDoanhThuNam(int year)
        {
            using (PKNK_ContextDB model = new PKNK_ContextDB())
            {
                // Lấy tất cả các hóa đơn trong năm cụ thể
                var doanhThuNam = model.HoaDons
                    .Where(h => h.Ngay != null && h.Ngay.Year == year)
                    .Select(h => h.ThanhTien);

                if (doanhThuNam.Any())
                {
                    // Tính tổng doanh thu
                    return doanhThuNam.Sum();
                }
                else
                {
                    // Nếu không có hóa đơn nào trong năm, trả về 0
                    return 0;
                }
            }
        }

        public void Add(HoaDon cd)
        {
            PKNK_ContextDB model = new PKNK_ContextDB();
            model.HoaDons.AddOrUpdate(cd);
            model.SaveChanges();
        }
    }
}
