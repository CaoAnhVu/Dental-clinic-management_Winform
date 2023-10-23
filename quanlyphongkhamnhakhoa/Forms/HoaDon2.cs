using PKNK.BUS.Servive;
using PKNK.BUS.Report;
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
using Microsoft.Reporting.WinForms;

namespace PKNK_CNPM.Forms
{
    public partial class frmHoaDon2 : Form
    {
        private readonly TTLamSanServive ttLsService = new TTLamSanServive();
        private readonly DonThuocService ttThuocService = new DonThuocService();
        private readonly KhachHangService khService = new KhachHangService();
        private readonly ThuocService thuocService = new ThuocService();
        private ChanDoan chanDoan;
        private decimal total = 0;
        public frmHoaDon2(ChanDoan chanDoan)
        {
            InitializeComponent();
            this.chanDoan = chanDoan;
        }

        private void HoaDon2_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "Reporting/rptHoaDon.rdlc";
            ReportDataSource sourceLs = new ReportDataSource("ThongTinLs", GetTTLamSanReport());
            ReportDataSource sourceThuoc = new ReportDataSource("ThongTinThuoc", GetTTThuocReport());
            ReportDataSource sourceHd = new ReportDataSource("HoaDon", GetTTHoaDon());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sourceLs);
            reportViewer1.LocalReport.DataSources.Add(sourceHd);
            reportViewer1.LocalReport.DataSources.Add(sourceThuoc);
            this.reportViewer1.RefreshReport();
        }

        private List<HoaDonReport> GetTTHoaDon()
        {
            BenhNhan khachHanh = khService.FindById(chanDoan.MaBN);
            HoaDonReport hoaDon = new HoaDonReport
            {
                MaBN = khachHanh.MaBN.ToString(),
                TenBN = khachHanh.TenBN,
                SDT = khachHanh.SDT,
                NamSinh = String.Format("{0:dd/MM/yyyy}", khachHanh.NgaySinh),
                DiaChi = khachHanh.DiaChi,
                GioiTinh = khachHanh.GioiTinh ? "Nam" : "Nữ",
                NgayTao = DateTime.Now.ToString(),
                TongTien = total.ToString(),
            };
            List<HoaDonReport> hoaDonList = new List<HoaDonReport>();
            hoaDonList.Add(hoaDon);
            return hoaDonList;
        }

        private List<ThongTinThuocReport> GetTTThuocReport()
        {
            List<DonThuoc> ttThuocList = ttThuocService.FindByMaChuanDoan(chanDoan.MaChanDoan);
            List<ThongTinThuocReport> ttThuocReport = new List<ThongTinThuocReport>();
            foreach (DonThuoc i in ttThuocList)
            {
                ThongTinThuocReport temp = new ThongTinThuocReport
                {
                    TenDonThuoc = thuocService.SearchById(i.MaThuoc).TenThuoc,
                    SoLuong = i.SoLuong.ToString(),
                    ThanhTien = i.ThanhTien.ToString(),
                    DonGia = i.Thuoc.DonGia.ToString(),
                };
                total += i.ThanhTien;
                ttThuocReport.Add(temp);
            }
            return ttThuocReport;
        }

        private List<ThongTinLsReport> GetTTLamSanReport()
        {
            List<ThongTinL> ttLsList = ttLsService.FindByMaChuanDoan(chanDoan.MaChanDoan);
            List<ThongTinLsReport> ttlsReport = new List<ThongTinLsReport>();
            foreach (ThongTinL i in ttLsList)
            {
                ThongTinLsReport temp = new ThongTinLsReport();
                temp.Loai = i.LoaiThuThuat.TenLoaiThuThuat;
                temp.TenThuThuat = i.ThuThuat.TenThuThuat;
                temp.SoLuong = i.SoLuong.ToString();
                temp.DonGia = i.ThuThuat.DonGia.ToString();
                temp.GiamGia = i.GiamGia.ToString() + "%";
                temp.ThanhTien = (decimal)(i.SoLuong * i.ThuThuat.DonGia * (100 - i.GiamGia) / 100);
                total += temp.ThanhTien;
                ttlsReport.Add(temp);
            }
            return ttlsReport;
        }
    }
}
