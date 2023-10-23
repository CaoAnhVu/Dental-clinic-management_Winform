using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using PKNK_CNPM.FormCustomer.Controller;
using PKNK_CNPM.Forms;
using PKNK_CNPM.FormsSetting;
using PKNK_CNPM.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKNK_CNPM.FormCustomer
{
    public partial class frmCanLamSang : Form
    {
        // Service -----------------------
        private readonly LoaiThuThuatService loaiThuThuatService = new LoaiThuThuatService();
        private readonly TTLamSanServive thongTinLsServive = new TTLamSanServive();
        private readonly DonThuocService donThuocService = new DonThuocService();
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly ChanDoanService chuanDoanService = new ChanDoanService();
        private readonly ThuocService thuocService = new ThuocService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        // -------------------------------
        private BenhNhan khachHang;
        private ChanDoan chanDoan;
        private List<ThongTinL> thongTins = new List<ThongTinL>();
        private List<DonThuoc> thuocs = new List<DonThuoc>();
        private decimal TongTien = 0;
        // FUNCTION-----------------------
        public frmCanLamSang(BenhNhan khachHang)
        {
            this.khachHang = khachHang;
            InitializeComponent();
        }
        
        private void populateThuThuatItems()
        {
            List<LoaiThuThuat> thuThuats = loaiThuThuatService.GetAll();
            ThuThuatItem[] thuThuatItems = new ThuThuatItem[thuThuats.Count];
            for(int i = 0; i < thuThuatItems.Length; i++)
            {
                thuThuatItems[i] = new ThuThuatItem();
                thuThuatItems[i].Title = thuThuats[i].MaLoaiThuThuat;
                thuThuatItems[i].Description = thuThuats[i].TenLoaiThuThuat;
                thuThuatItems[i].Cursor = Cursors.Hand;
                thuThuatItems[i].LoaiThuThuat = thuThuats[i];
                if (flpThuThuat.Controls.Count < 0)
                {
                    flpThuThuat.Controls.Clear();
                }
                else
                {
                    flpThuThuat.Controls.Add(thuThuatItems[i]);
                }
                thuThuatItems[i].Click += new System.EventHandler(ThuThuatControl_Click);
            }
        }

        private void populateThuocItems()
        {
            List<Thuoc> thuocs = thuocService.GetAll();
            ThuocItem[] thuocItems = new ThuocItem[thuocs.Count];
            for (int i = 0; i < thuocItems.Length; i++)
            {
                thuocItems[i] = new ThuocItem();
                thuocItems[i].UID = thuocs[i].MaThuoc;
                thuocItems[i].Cursor = Cursors.Hand;
                if (flpThuoc.Controls.Count < 0)
                {
                    flpThuoc.Controls.Clear();
                }
                else
                {
                    flpThuoc.Controls.Add(thuocItems[i]);
                }
                thuocItems[i].Click += new System.EventHandler(ThuocControl_Click);
            }
        }

        private void populateNhanVienCombobox()
        {
            List<NhanVien> list = nhanVienService.GetAll();
            cbNhanVien.DataSource = list;
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadValue()
        {
            if(khachHang != null)
            {
                txtMaKH.Text = khachHang.MaBN.ToString();
                txtTenKH.Text = khachHang.TenBN;
            }
        }

        private void Luu()
        {
            try
            {
                getThongTinThuThuat();
                getThongTinThuoc();
                chuanDoanService.Add(chanDoan);
                foreach (var item in thuocs)
                {
                    if (item != null)
                    {
                        item.MaChanDoan = chanDoan.MaChanDoan;
                        donThuocService.Add(item);
                    }
                }
                foreach (var item in thongTins)
                {
                    if (item != null)
                    {
                        item.MaChanDoan = chanDoan.MaChanDoan;
                        thongTinLsServive.Add(item);
                    }
                }
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getThongTinThuThuat()
        {
            for(int  i = 0; i < flpThemThuThuat.Controls.Count; i++)
            {
                if (flpThemThuThuat.Controls[i] is TTThuThuatItem thuThuatItem)
                {
                    ThongTinL tt = new ThongTinL
                    {
                        NoiDungDieuTri = thuThuatItem.NoiDung,
                        ThanhTien = thuThuatItem.ThanhTien,
                        MaNV = thuThuatItem.NhanVien.MaNhanVien,
                        MaThuThuat = thuThuatItem.MaThuThuat,
                        MaLoaiThuThuat = thuThuatItem.MaLoaiThuThuat,
                        SoLuong = thuThuatItem.SoLuong,
                        GiamGia = thuThuatItem.GiamGia,
                    };
                    thongTins.Add(tt);
                }
            }
        }
        private void getThongTinThuoc()
        {
            for (int i = 0; i < flpThemThuoc.Controls.Count; i++)
            {
                if (flpThemThuoc.Controls[i] is DonThuocItem thuocItem)
                {
                    DonThuoc tt = new DonThuoc
                    {
                        MaThuoc = thuocItem.Thuoc.MaThuoc,
                        GhiChu = thuocItem.GhiChu,
                        SoLuong = thuocItem.SoLuong,
                        ThanhTien = thuocItem.Thuoc.DonGia * thuocItem.SoLuong,
                    };
                    thuocs.Add(tt);
                }
            }
        }
        private void XuatHoaDon()
        {
            HoaDon hoaDon = new HoaDon
            {
                Ngay = DateTime.Now,
                ThanhTien = donThuocService.TongTienByMaChuanDoan(chanDoan.MaChanDoan) + thongTinLsServive.TongTienByMaChuanDoan(chanDoan.MaChanDoan),
                MaChanDoan = chanDoan.MaChanDoan,
            };
            hoaDonService.Add(hoaDon);
        }
        private void SetThongTinPanel()
        {
            if (flpThemThuThuat.Controls.Count == 0)
                flpThemThuThuat.Controls.Add(new ThongTinItems());
            if (flpThemThuoc.Controls.Count == 0)
                flpThemThuoc.Controls.Add(new TTThuocItem());
        }
        // HANDER-------------------
        private void frmCanLamSang_Load(object sender, EventArgs e)
        {
            populateNhanVienCombobox();
            populateThuThuatItems();
            populateThuocItems();
            SetThongTinPanel();
            loadValue();
            chanDoan = new ChanDoan
            {
                MaChanDoan = chuanDoanService.GetUid(),
                MaBN = int.Parse(txtMaKH.Text),
            };
            txtMaChuanDoan.Text = chanDoan.MaChanDoan.ToString();
        }
        // Click //
        void ThuocControl_Click(object sender, EventArgs e)
        {
            ThuocItem thuThuatItem = (ThuocItem)sender;
            flpThemThuoc.Controls.Add(new DonThuocItem(thuThuatItem.UID, this.flpThemThuoc));
        }
        void ThuThuatControl_Click(object sender, EventArgs e) {
            ThuThuatItem thuThuatItem = (ThuThuatItem)sender;
            flpThemThuThuat.Controls.Add(new TTThuThuatItem(thuThuatItem.LoaiThuThuat, this.flpThemThuThuat));
        }
        private void btnHoSoPhongKham_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmThemKhach = new frmThemKhachHang(true, khachHang);
            frmThemKhach.ShowDialog();
        }
        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            try
            {
                Luu();
                frmPhieuKham frm = new frmPhieuKham(chanDoan.MaChanDoan);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        getThongTinThuThuat();
        //        getThongTinThuoc();
        //        chuanDoanService.Add(chanDoan);
        //        foreach (var item in thuocs)
        //        {
        //            if (item != null)
        //            {
        //                item.MaChanDoan = chanDoan.MaChanDoan;
        //                donThuocService.Add(item);
        //            }
        //        }
        //        foreach (var item in thongTins)
        //        {
        //            if (item != null)
        //            {
        //                item.MaChanDoan = chanDoan.MaChanDoan;
        //                thongTinLsServive.Add(item);
        //            }
        //        }
        //        MessageBox.Show("Lưu thành công!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Luu();
                XuatHoaDon();
                frmHoaDon2 frm = new frmHoaDon2(chanDoan);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnHSBN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
