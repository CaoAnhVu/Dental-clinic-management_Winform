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
    public partial class ThemHoaDonXuatNhap : Form
    {
        private readonly XuatNhapService hoaDonService = new XuatNhapService();
        private readonly NhanVienService nhanVienService = new NhanVienService();

        public ThemHoaDonXuatNhap()
        {
            InitializeComponent();
        }

        private bool checkValue()
        {
            if (txtDonGia.Text != "" && txtDVT.Text != "" && txtSL.Text != "" && rtbNoiDung.Text != "")
            {
                return true;
            }
            return false;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dữ liệu chưa được lưu, Bạn có muốn thoát không?", "Hệ thống", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FillNhanVienCombobox(List<NhanVien> list)
        {
            list.Insert(0, new NhanVien());
            this.cbNhanVien.DataSource = list;
            this.cbNhanVien.DisplayMember = "TenNhanVien";
            this.cbNhanVien.ValueMember = "MaNhanVien";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Hander valid
                if (!checkValue())
                    throw new Exception("Chưa nhập đầy đủ thông tin!");
                NhanVien selectedNhanVien = (NhanVien)cbNhanVien.SelectedItem;
                DonXuatNhap value = new DonXuatNhap()
                {
                    DonGia = decimal.Parse(txtDonGia.Text),
                    DVT = txtDVT.Text,
                    SoLuong = int.Parse(txtSL.Text),
                    MaNhanVien = selectedNhanVien.MaNhanVien,
                    NoiDung = rtbNoiDung.Text,
                    ThanhTien = int.Parse(txtSL.Text) * decimal.Parse(txtDonGia.Text),
                };

                hoaDonService.Add(value);
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemHoaDonXuatNhap_Load(object sender, EventArgs e)
        {
            FillNhanVienCombobox(nhanVienService.GetAll());
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(txtDonGia.Text != "" && txtSL.Text != "")
            {
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * decimal.Parse(txtSL.Text)).ToString();
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "" && txtSL.Text != "")
            {
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * decimal.Parse(txtSL.Text)).ToString();
            }
        }
    }
}
