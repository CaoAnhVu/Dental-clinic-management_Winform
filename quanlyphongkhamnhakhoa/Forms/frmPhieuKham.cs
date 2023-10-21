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

namespace PKNK_CNPM.Forms
{
    public partial class frmPhieuKham : Form
    {
        private List<ThongTinL> thongTins;
        private double TongTien = 0, TongGiamGia;
        public frmPhieuKham(List<ThongTinL> thongTins)
        {
            InitializeComponent();
            this.thongTins = thongTins;
        }

        private void setValue()
        {
            foreach(ThongTinL i in thongTins)
            {
                TongTien += (double)(i.SoLuong * i.ThanhTien);
                TongGiamGia += (double)(i.SoLuong * i.ThanhTien * (100 - i.GiamGia) / 100);
            }
            txtTongTien.Text = TongTien.ToString();
            txtTienGiam.Text = (TongTien - TongGiamGia).ToString();
        }

        private void frmPhieuKham_Load(object sender, EventArgs e)
        {
            setValue();
        }
    }
}
