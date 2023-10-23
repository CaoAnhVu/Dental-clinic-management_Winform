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
    public partial class frmHoaDonXuatNhap : Form
    {
        private readonly XuatNhapService donXuat = new XuatNhapService();
        public frmHoaDonXuatNhap()
        {
            InitializeComponent();
        }

        private void BindGrid(List<DonXuatNhap> list)
        {
            try
            {
                dtgvHoaDon.Rows.Clear();
                foreach (DonXuatNhap i in list)
                {
                    int index = dtgvHoaDon.Rows.Add();
                    dtgvHoaDon.Rows[index].Cells[0].Value = i.MaDonXuatNhap;
                    dtgvHoaDon.Rows[index].Cells[1].Value = i.NoiDung;
                    dtgvHoaDon.Rows[index].Cells[2].Value = i.DVT;
                    dtgvHoaDon.Rows[index].Cells[3].Value = i.SoLuong;
                    dtgvHoaDon.Rows[index].Cells[4].Value = i.DonGia;
                    dtgvHoaDon.Rows[index].Cells[5].Value = i.ThanhTien;
                    dtgvHoaDon.Rows[index].Cells[6].Value = i.NhanVien.TenNhanVien; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BindGrid frmHoaDonXuatNhap Ex:" + ex.Message);
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemHoaDonXuatNhap frm = new ThemHoaDonXuatNhap();
            frm.ShowDialog();
            BindGrid(donXuat.GetAll());
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            BindGrid(donXuat.GetAll());
        }

        private void frmHoaDonXuatNhap_Load(object sender, EventArgs e)
        {
            BindGrid(donXuat.GetAll());
        }
    }
}
