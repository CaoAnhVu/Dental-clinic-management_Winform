using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using PKNK_CNPM.FormCustomer;
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
    public partial class frmThemKhachHang : Form
    {
        private readonly KhachHangService benhNhanService = new KhachHangService();
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private bool isEdit = false;
        private BenhNhan khachHang;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        public frmThemKhachHang(bool isSave, BenhNhan khachHang)
        {
            InitializeComponent();
            this.isEdit = isSave;
            this.khachHang = khachHang;
        }
        // FUNC
        private void clearValue()
        {
            txtTenKH.Text = txtMaKH.Text = "";
        }

        private bool checkValue()
        {
            if (txtTenKH.Text != "" && txtSDT.Text != "")
            {
                return true;
            }
            return false;
        }

        private void loadValue()
        {
            if (isEdit && khachHang != null)
            {
                txtMaKH.Enabled = false;
                txtMaKH.Text = khachHang.MaBN.ToString();
                txtTenKH.Text = khachHang.TenBN;
                txtSDT.Text = khachHang.SDT;
                txtDiaChi.Text = khachHang.DiaChi;
                txtSDT.Text = khachHang.SDT;
                rtbLyDo.Text = khachHang.GhiChu;
                if (khachHang.DuongHuyet != null)
                    cbDuongHuyet.Checked = khachHang.DuongHuyet.Value;
                if (khachHang.HuyetApMach != null)
                    cbHuyetAp.Checked = khachHang.HuyetApMach.Value;
                if (khachHang.MauKhoDong != null)
                    cbMauKhoDong.Checked = khachHang.MauKhoDong.Value;
                if (khachHang.ThieuNangTriTue != null)
                    cbThieuNang.Checked = khachHang.ThieuNangTriTue.Value;
                dtpNgaySinh.Value = khachHang.NgaySinh.Value;
                // Select item trong combobox
                if (khachHang.GioiTinh == true)
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
            }
            else
            {
                txtMaKH.Enabled = false;
            }
        }

       
        //
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            loadValue();
            populateNhanVienCombobox();
        }

        private void populateNhanVienCombobox()
        {
            List<NhanVien> list = nhanVienService.GetAll();
            cbNhanVien.DataSource = list;
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadComboBox()
        {
            foreach (var item in cbNhanVien.Items)
            {
                if (((NhanVien)item).MaNhanVien == khachHang.MaNV)
                {
                    cbNhanVien.SelectedItem = item;
                    break;
                }
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Hander valid
                if (!checkValue())
                    throw new Exception("Chưa nhập đầy đủ thông tin!");
                if (txtTenKH.Text.Length > 255)
                    throw new Exception("Tên nhân viên quá 255 kí tự!");
                if (!CheckValidService.IsVietnamesePhoneNumber(txtSDT.Text))
                    throw new Exception("Số điện thoại không hợp lệ!");
                NhanVien selectedNhanVien = (NhanVien)cbNhanVien.SelectedItem;
                BenhNhan value = new BenhNhan()
                {
                    TenBN = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    GioiTinh = rbNam.Checked == true ? true : false,
                    NgayTao = DateTime.Now,
                    NgaySinh = (DateTime)dtpNgaySinh.Value,
                    DiaChi = txtDiaChi.Text,
                    GhiChu = rtbLyDo.Text,
                    DuongHuyet = cbDuongHuyet.Checked,
                    HuyetApMach = cbDuongHuyet.Checked,
                    MauKhoDong = cbDuongHuyet.Checked,
                    ThieuNangTriTue = cbDuongHuyet.Checked,
                    MaNV = selectedNhanVien.MaNhanVien,
                };
              
                

                if (isEdit)
                {
                    value.MaBN = int.Parse(txtMaKH.Text);
                    benhNhanService.Update(value);
                    MessageBox.Show("Sửa khách hàng thành công!");
                }
                else
                {
                    benhNhanService.Add(value);
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                clearValue();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                DialogResult res = MessageBox.Show("Dữ liệu chưa được lưu, Bạn có muốn thoát không?", "Hệ thống", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
