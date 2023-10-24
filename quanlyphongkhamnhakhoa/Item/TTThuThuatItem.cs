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
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace PKNK_CNPM.Item
{
    public partial class TTThuThuatItem : UserControl
    {
        private readonly ThuThuatService _ttService = new ThuThuatService();
        private readonly NhanVienService _bsService = new NhanVienService();
        private LoaiThuThuat loaiThuThuat;
        private List<ThuThuat> thuThuatList;
        private ThuThuat thuThuat;
        private FlowLayoutPanel flpThemThuThuat;

        #region Properties
        [Category("Custom Props")]
        public DateTime DtpNgay
        {
            get { return (DateTime)dtpNgay.Value; }
        }
        [Category("Custom Props")]
        public string sThuThuat
        {
            get { return txtThuThuat.Text;}

        }
        [Category("Custom Props")]
        public string NoiDung
        {
            get { return txtNoiDung.Text; }
        }
        [Category("Custom Props")]
        public int SoLuong
        {
            get { return txtSoLuong.Text != "" ? int.Parse(txtSoLuong.Text) : 0; }
        }

        [Category("Custom Props")]
        public int GiamGia
        {
            get { return txtGG.Text != "" ? int.Parse(txtGG.Text) : 0; }
        }

        [Category("Custom Props")]
        public decimal ThanhTien
        {
            get { return decimal.Parse(txtThanhTien.Text); }
        }

        [Category("Custom Props")]
        public NhanVien NhanVien
        {
            get { return (NhanVien)cbBacSi.SelectedItem; }
        }

        [Category("Custom Props")]
        public string MaLoaiThuThuat
        {
            get { return loaiThuThuat.MaLoaiThuThuat; }
        }
        [Category("Custom Props")]
        public string MaThuThuat
        {
            get { return thuThuat.MaThuThuat; }
        }

        #endregion

        public TTThuThuatItem(LoaiThuThuat loaiThuThuat, FlowLayoutPanel flpThemThuThuat)
        {
            InitializeComponent();
            this.loaiThuThuat = loaiThuThuat;
            this.flpThemThuThuat = flpThemThuThuat;
            thuThuatList = _ttService.FindTypeById(loaiThuThuat.MaLoaiThuThuat);
            thuThuat = thuThuatList[0];
        }
        private void TTThuThuatItem_Load(object sender, EventArgs e)
        {
            FillThuThuatCombobox();
            FillBacSiCombobox();
            SetValue();
        }
        private void FillThuThuatCombobox()
        {
            cbLoaiTT.DataSource = thuThuatList;
            cbLoaiTT.DisplayMember = "TenThuThuat";
            cbLoaiTT.ValueMember = "MaThuThuat";
        }
        private void FillBacSiCombobox()
        {
            List<NhanVien> nhanViens = _bsService.GetAll();
            cbBacSi.DataSource = nhanViens;
            cbBacSi.DisplayMember = "TenNhanVien";
            cbBacSi.ValueMember = "MaNhanVien";
        }
        private void SetValue()
        {
            txtThuThuat.Text = loaiThuThuat.TenLoaiThuThuat;
            txtVatLieu.Text = thuThuat.DVT;
            txtDonGia.Text = thuThuat.DonGia.ToString();
            txtThanhTien.Text = (thuThuat.DonGia * int.Parse(txtSoLuong.Text) * (100 - int.Parse(txtGG.Text))/100).ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (flpThemThuThuat != null)
            {
                flpThemThuThuat.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void cbLoaiTT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbLoaiTT.SelectedIndex > 0)
            {
                thuThuat = (ThuThuat)cbLoaiTT.SelectedItem;
                SetValue();
            }
        }

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                SetValue();
            }
        }

        private void txtGG_TextChanged_1(object sender, EventArgs e)
        {
            if (txtGG.Text != "")
            {
                SetValue();
            }
        }

        private void txtGG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}