using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using PKNK_CNPM.FormCustomer.Controller;
using PKNK_CNPM.FormsSetting;
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
        private readonly ThuThuatService thuThuatService = new ThuThuatService();
        private readonly LoaiThuThuatService loaiThuThuatService = new LoaiThuThuatService();
        private readonly ThuocService thuocService = new ThuocService();

        public frmCanLamSang(BenhNhan khachHang)
        {
            this.khachHang = khachHang;
            InitializeComponent();
        }

        private void populateThuThuatItems()
        {
            List<LoaiThuThuat> thuThuats = loaiThuThuatService.GetAll();
            ThuThuatItem[] listItems = new ThuThuatItem[thuThuats.Count];
            for(int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ThuThuatItem();
                listItems[i].Title = thuThuats[i].MaLoaiThuThuat;
                listItems[i].Description = thuThuats[i].TenLoaiThuThuat;
                listItems[i].Price = "";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }
            
        }

        private void populateThuocItems()
        {
            List<Thuoc> thuocs = thuocService.GetAll();
            ThuocItem[] thuocItems = new ThuocItem[thuocs.Count];
            for (int i = 0; i < thuocItems.Length; i++)
            {
                thuocItems[i] = new ThuocItem();
                thuocItems[i].Title = thuocs[i].TenThuoc;
                thuocItems[i].Price = thuocs[i].DonGia.ToString();
                if (flpThuoc.Controls.Count < 0)
                {
                    flpThuoc.Controls.Clear();
                }
                else
                {
                    flpThuoc.Controls.Add(thuocItems[i]);
                }
            }
        }

        private void frmCanLamSang_Load(object sender, EventArgs e)
        {
            populateThuThuatItems();
            populateThuocItems();
        }

        private void btnHoSoPhongKham_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {

        }
    }
}
