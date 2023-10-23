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

namespace PKNK_CNPM.Forms
{
    public partial class frmPhieuKham : Form
    {
        private readonly TTLamSanServive thongTinLsServive = new TTLamSanServive();
        private readonly DonThuocService donThuocServive = new DonThuocService();

        private int MaChuanDoan;
        private List<ThongTinL> thongTinLamSan;
        private List<DonThuoc> thongTinDonThuoc;
        private double TongTienTT = 0,TongTienThuoc = 0,  TongGiamGia;
        public frmPhieuKham(int maChuanDoan)
        {
            InitializeComponent();
            this.MaChuanDoan = maChuanDoan;
        }

        private void GetValue()
        {
            thongTinLamSan = thongTinLsServive.FindByMaChuanDoan(MaChuanDoan);
            thongTinDonThuoc = donThuocServive.FindByMaChuanDoan(MaChuanDoan);
            // Set value ThuThuat
            if (thongTinLamSan.Count != 0)
            {
                foreach (ThongTinL i in thongTinLamSan)
                {
                    TongTienTT += (double)(i.SoLuong * i.ThanhTien);
                    TongGiamGia += (double)(i.SoLuong * i.ThanhTien * (100 - i.GiamGia) / 100);
                }
            }
            // Set value Thuoc
            if (thongTinDonThuoc.Count != 0)
            {
                foreach (DonThuoc i in thongTinDonThuoc)
                {
                    TongTienThuoc += (double)(i.SoLuong * i.ThanhTien);
                }
            }
        }

        private void SetValue()
        {
            txtTongTien.Text = (TongTienThuoc + TongTienTT).ToString();
            txtTienGiam.Text = (TongTienTT - TongGiamGia).ToString();
        }

        private void frmPhieuKham_Load(object sender, EventArgs e)
        {
            GetValue();
            SetValue();
        }
    }
}
