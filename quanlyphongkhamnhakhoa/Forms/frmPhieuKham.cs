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
        private readonly HoaDonService hoaDonService = new HoaDonService();

        private ChanDoan chanDoan;
        private List<ThongTinL> thongTinLamSan;
        private List<DonThuoc> thongTinDonThuoc;
        private double TongTienTT = 0,TongTienThuoc = 0,  TongGiamGia;
        public frmPhieuKham(ChanDoan chanDoan)
        {
            InitializeComponent();
            this.chanDoan = chanDoan;
        }

        private void GetValue()
        {
            thongTinLamSan = thongTinLsServive.FindByMaChuanDoan(chanDoan.MaChanDoan);
            thongTinDonThuoc = donThuocServive.FindByMaChuanDoan(chanDoan.MaChanDoan);
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

        private void btnLuuLai_Click(object sender, EventArgs e)
        {

            btnInHoaDon.Enabled = true;
        }

        private void XuatHoaDon()
        {
            HoaDon hoaDon = new HoaDon
            {
                Ngay = DateTime.Now,
                ThanhTien = donThuocServive.TongTienByMaChuanDoan(chanDoan.MaChanDoan) + thongTinLsServive.TongTienByMaChuanDoan(chanDoan.MaChanDoan),
                MaChanDoan = chanDoan.MaChanDoan,
            };
            hoaDonService.Add(hoaDon);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                XuatHoaDon();
                frmHoaDon2 frm = new frmHoaDon2(chanDoan);
                frm.ShowDialog();
                this.Close();
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
