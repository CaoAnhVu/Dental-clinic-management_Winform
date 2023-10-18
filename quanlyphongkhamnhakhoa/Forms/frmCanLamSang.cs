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
        private BenhNhan khachHang;
        private readonly LoaiThuThuatService loaiThuThuatService = new LoaiThuThuatService();
        private readonly ThuThuatService thuThuatService = new ThuThuatService();
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly ThuocService thuocService = new ThuocService();

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
                thuThuatItems[i].Price = "";
                thuThuatItems[i].Cursor = Cursors.Hand;
                if (flpThuThuat.Controls.Count < 0)
                {
                    flpThuThuat.Controls.Clear();
                }
                else
                {
                    flpThuThuat.Controls.Add(thuThuatItems[i]);
                }
                thuThuatItems[i].Click += (sender, e) => ThuThuatControl_Click(this, e, thuThuats[i]);
            }
        }

        private void populateThuocItems()
        {
            List<Thuoc> thuocs = thuocService.GetAll();
            ThuocItem[] thuocItems = new ThuocItem[thuocs.Count];
            for (int i = 0; i < thuocItems.Length; i++)
            {
                var ThuocItem = new ThuocItem
                {
                    Title = thuocs[i].TenThuoc,
                    Price = thuocs[i].DonGia.ToString(),
                    Cursor = Cursors.Hand,
                };
                if (flpThuoc.Controls.Count < 0)
                {
                    flpThuoc.Controls.Clear();
                }
                else
                {
                    flpThuoc.Controls.Add(ThuocItem);
                }
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

        void ThuThuatControl_Click(object sender, EventArgs e, LoaiThuThuat ltt) {
            ThuThuatItem thuThuatItem = (ThuThuatItem)sender;
            flpThemThuThuat.Controls.Add(new ThongTinItems());
            flpThemThuThuat.Controls.Add(new TTThuThuatItem(ltt));
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
    }
}
