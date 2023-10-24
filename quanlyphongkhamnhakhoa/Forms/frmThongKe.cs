using PKNK.BUS.Servive;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PKNK_CNPM.Forms
{
    public partial class frmThongKe : Form
    {
        private HoaDonService hoaDonService = new HoaDonService();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void DoanhThuThang()
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            int[] doanhThuThang = hoaDonService.GetDoanhThuThang();
            //MessageBox.Show(doanhThuThang.ToString());

            Series series = new Series("Doanh thu hàng tháng");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < doanhThuThang.Length; i++)
            {
                series.Points.AddXY(i + 1, doanhThuThang[i]);
            }
            chartThongKe.Series.Add(series);
            chartThongKe.ChartAreas[0].AxisX.Title = "Tháng";
            chartThongKe.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartThongKe.Titles.Add(new Title("Biểu đồ Doanh thu tháng"));
            chartThongKe.Invalidate();
        }
        private void DoanhThuQuy()
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            int[] doanhThuThang = hoaDonService.GetDoanhThuThang();
            int[] doanhThuQuy = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int temp = doanhThuThang[i * 3] + doanhThuThang[i * 3 + 1] + doanhThuThang[i * 3 + 2];
                doanhThuQuy[i] = temp;
            }
            Series series = new Series("Doanh thu hàng quý");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < 4; i++)
            {
                series.Points.AddXY(i + 1, doanhThuQuy[i]);
            }
            chartThongKe.Series.Add(series);
            chartThongKe.ChartAreas[0].AxisX.Title = "Quý";
            chartThongKe.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartThongKe.Titles.Add(new Title("Biểu đồ Doanh thu quý"));
            chartThongKe.Invalidate();
        }

        private void DoanhThuNam()
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            using (PKNK_ContextDB model = new PKNK_ContextDB())
            {
                var namNhoNhat = model.HoaDons.Min(h => h.Ngay.Year);

                int namHienTai = DateTime.Now.Year;

                // Tạo mảng doanh thu tháng
                int soNam = namHienTai - namNhoNhat + 1;
                int[] doanhThuNam = new int[soNam];

                for (int i = 0; i < soNam; i++)
                {
                    int nam = namNhoNhat + i;
                    doanhThuNam[i] = (int)hoaDonService.GetDoanhThuNam(nam);
                }

                Series series = new Series("Doanh thu hàng năm");
                series.ChartType = SeriesChartType.Column;

                for (int i = 0; i < soNam; i++)
                {
                    series.Points.AddXY(namNhoNhat + i, doanhThuNam[i]);
                }

                chartThongKe.Series.Add(series);
                chartThongKe.ChartAreas[0].AxisX.Title = "Năm";
                chartThongKe.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                chartThongKe.Titles.Add(new Title("Biểu đồ Doanh thu năm"));
            }
        }


        private void rbDtThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDtThang.Checked)
            {
                DoanhThuThang();
            }
        }

        private void rbDtNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDtNam.Checked)
            {
                DoanhThuNam();
            }
        }

        private void rbDtQuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDtQuy.Checked)
            {
                DoanhThuQuy();
            }
        }

        private void rbVlThang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbVlNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbVlQuy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DoanhThuThang();
        }
    }
}
