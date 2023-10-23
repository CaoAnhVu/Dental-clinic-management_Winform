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
using static System.Net.Mime.MediaTypeNames;

namespace PKNK_CNPM.FormCustomer.Controller
{
    public partial class DonThuocItem : UserControl
    {
        private readonly ThuocService _thuocService = new ThuocService();
        private readonly NhanVienService _bsService = new NhanVienService();
        private Thuoc thuoc;
        private FlowLayoutPanel flpThemDonThuoc;

        #region Properties
        [Category("Custom Props")]
        public int SoLuong
        {
            get { return int.Parse(txtSoLuong.Text); }

        }
        [Category("Custom Props")]
        public string GhiChu
        {
            get { return txtGhiChu.Text; }
        }
        [Category("Custom Props")]
        public Thuoc Thuoc
        {
            get { return thuoc; }
        }
        #endregion

        public DonThuocItem(string maThuoc, FlowLayoutPanel flpThemThuoc)
        {
            InitializeComponent();
            this.thuoc = _thuocService.SearchById(maThuoc);
            this.flpThemDonThuoc = flpThemThuoc;
        }
        private void SetValue()
        {
            txtDonVi.Text = thuoc.DVT;
            txtTenThuoc.Text = thuoc.TenThuoc;
            txtDonGia.Text = thuoc.DonGia.ToString();
            txtSTT.Text = thuoc.MaThuoc;
            txtThanhTien.Text = (thuoc.DonGia * int.Parse(txtSoLuong.Text)).ToString();
        }
        private void ChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            SetValue();

        }
        private void txtSoLuong_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
                SetValue();
        }

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (flpThemDonThuoc != null)
            {
                flpThemDonThuoc.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
