using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PKNK_CNPM.Forms
{
    public partial class frmThongKeVatLieu : Form
    {
        public frmThongKeVatLieu()
        {
            InitializeComponent();
        }

        private void ThongKeTheoThuThuat()
        {
            // Tạo một Dictionary để lưu trữ doanh thu theo tên thu thủật
            Dictionary<string, decimal> doanhThuTheoThuThuat = new Dictionary<string, decimal>();

            using (PKNK_ContextDB db = new PKNK_ContextDB())
            {
                // Lấy dữ liệu từ database
                List<ThongTinL> thongTinLSList = db.ThongTinLS.ToList();

                // Tính tổng doanh thu cho từng loại thu thủật
                foreach (ThongTinL thongTin in thongTinLSList)
                {
                    string tenThuThuat = thongTin.ThuThuat.TenThuThuat;
                    decimal thanhTien = thongTin.ThanhTien;

                    if (doanhThuTheoThuThuat.ContainsKey(tenThuThuat))
                    {
                        doanhThuTheoThuThuat[tenThuThuat] += thanhTien;
                    }
                    else
                    {
                        doanhThuTheoThuThuat[tenThuThuat] = thanhTien;
                    }
                }
            }

            // Xóa dữ liệu cũ trong biểu đồ
            chartVaLieu.Series.Clear();

            // Tạo một series cho biểu đồ
            Series series1 = new Series("Biểu đồ Thông kê theo Thu Thuật");
            series1.ChartType = SeriesChartType.Pie;

            // Thêm dữ liệu vào series
            foreach (var kvp in doanhThuTheoThuThuat)
            {
                series1.Points.AddXY(kvp.Key, kvp.Value);
                series1.Color = Themecolor.PrimaryColor;
            }

            // Thêm series vào biểu đồ
            chartVaLieu.Series.Add(series1);
        }

        private void frmThongKeVatLieu_Load(object sender, EventArgs e)
        {
            ThongKeTheoThuThuat();
        }
    }
}
