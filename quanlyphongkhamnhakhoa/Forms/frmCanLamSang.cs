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
        private readonly ThuThuatService thuThuatService = new ThuThuatService();
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly ThuocService thuocService = new ThuocService();
        // -------------------------------
        private BenhNhan khachHang;
        private List<ThongTinL> thongTins = new List<ThongTinL>();
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
        void ThuocControl_Click(object sender, EventArgs e)
        {
            ThuocItem thuThuatItem = (ThuocItem)sender;
            flpThemThuoc.Controls.Add(new ChiTietDonThuoc(thuThuatItem.UID, this.flpThemThuoc));
        }
        void ThuThuatControl_Click(object sender, EventArgs e) {
            ThuThuatItem thuThuatItem = (ThuThuatItem)sender;
            if (flpThemThuThuat.Controls.Count == 0) 
                flpThemThuThuat.Controls.Add(new ThongTinItems());
            flpThemThuThuat.Controls.Add(new TTThuThuatItem(thuThuatItem.LoaiThuThuat, this.flpThemThuThuat));
        }
        private void frmCanLamSang_Load(object sender, EventArgs e)
        {
            populateNhanVienCombobox(); 
            populateThuThuatItems();
            populateThuocItems();
            loadValue();
        }
        private void btnHoSoPhongKham_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmThemKhach = new frmThemKhachHang(true, khachHang);
            frmThemKhach.ShowDialog();
        }
        private void btnDonThuoc_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            getThongTinThuThuat();
            frmPhieuKham frm = new frmPhieuKham(thongTins);
            MessageBox.Show(thongTins[0].ToString());
            frm.ShowDialog();
        }
    }
}
