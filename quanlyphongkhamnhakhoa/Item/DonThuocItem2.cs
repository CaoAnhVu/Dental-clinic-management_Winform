using PKNK.BUS.Servive;
using PKNK.DAL.Models;
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

namespace PKNK_CNPM.FormCustomer.Controller
{
    public partial class DonThuocItem2 : UserControl
    {
        //private readonly ThuocService _thuocService = new ThuocService();
        //private readonly NhanVienService _bsService = new NhanVienService();
        //private Thuoc thuoc;
        //private FlowLayoutPanel flpThemDonThuoc;

        //#region Properties
        //[Category("Custom Props")]
        //public Thuoc Thuoc
        //{
        //    get { return thuoc; }
        //}
        //[Category("Custom Props")]
        //public string SoLuong
        //{
        //    get { return txtSoLuong.Text; }

        //}
        //[Category("Custom Props")]
        //public string GhiChu
        //{
        //    get { return txt; }
        //}

        //public int GiamGia
        //{
        //    get { return int.Parse(txtGG.Text); }
        //}

        //public decimal ThanhTien
        //{
        //    get { return decimal.Parse(txtThanhTien.Text); }
        //}

        //public NhanVien NhanVien
        //{
        //    get { return (NhanVien)cbBacSi.SelectedItem; }
        //}

        //public string MaLoaiThuThuat
        //{
        //    get { return loaiThuThuat.MaLoaiThuThuat; }
        //}
        //public string MaThuThuat
        //{
        //    get { return thuThuat.MaThuThuat; }
        //}

        //#endregion

        //public DonThuocItem(String maThuoc, FlowLayoutPanel flpThemThuoc)
        //{
        //    InitializeComponent();
        //    this.thuoc = _thuocService.SearchById(maThuoc);
        //    this.flpThemDonThuoc = flpThemThuoc;
        //}
        //private void TTThuThuatItem_Load(object sender, EventArgs e)
        //{
        //    SetValue();
        //}
        //private void SetValue()
        //{
        //    txtDonVi.Text = thuoc.DVT;
        //    txtTenThuoc.Text = thuoc.TenThuoc;
        //}

        //private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtSoLuong_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtSoLuong.Text != "")
        //    {
        //        SetValue();
        //    }
        //}

        //private void txtGG_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void picXoa_Click(object sender, EventArgs e)
        //{
        //    if (flpThemDonThuoc != null)
        //    {
        //        flpThemDonThuoc.Controls.Remove(this);
        //        this.Dispose();
        //    }
        //}
    }
}
