using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PKNK_CNPM.FormsSetting
{
    public partial class frmThemNhanVien : Form
    {
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private bool isSave = false;
        private NhanVien nhanVien;
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        public frmThemNhanVien(bool isSave, NhanVien nhanVien)
        {
            InitializeComponent();
            this.isSave = isSave;
            this.nhanVien = nhanVien;
        }
        // FUNC
        private void clearValue()
        {
            txtTenNV.Text = txtMaNV.Text = txtSDT.Text = txtDiaChi.Text = txtEmail.Text = "";
        }

        private bool checkValue()
        {
            if (txtTenNV.Text != "" && txtMaNV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien existingNhanVien = nhanVienService.GetAll().FirstOrDefault(p => p.MaNhanVien == txtMaNV.Text);
                // Hander valid
                if (existingNhanVien != null && !isSave)
                    throw new Exception("Mã nhân viên đã có!");
                if (!checkValue())
                    throw new Exception("Chưa nhập đầy đủ thông tin!");
                if (txtMaNV.Text.Length != 5)
                    throw new Exception("Mã nhân viên phải bằng 5!");
                if (txtTenNV.Text.Length > 255)
                    throw new Exception("Tên nhân viên quá 255 kí tự!");
                if (!CheckValidService.IsVietnamesePhoneNumber(txtSDT.Text))
                    throw new Exception("Số điện thoại không hợp lệ!");
                if (!CheckValidService.IsEmailValid(txtEmail.Text))
                    throw new Exception("Email không hợp lệ!");
                if (txtDiaChi.Text.Length > 255)
                    throw new Exception("Tên nhân viên quá 255 kí tự!");

                NhanVien nhanVien = new NhanVien()
                {
                    MaNhanVien = txtMaNV.Text,
                    TenNhanVien = txtTenNV.Text,
                    Email = txtEmail.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDienThoai = txtSDT.Text,
                    MaChucDanh = "BS1",
                    GioiTinh = rbNam.Checked == true ? true : false,
                    NamSinh = (DateTime)dtNgaySinh.Value,
                    NgayTao = DateTime.Now,
                };

                if(isSave)
                    nhanVienService.Update(nhanVien);
                else
                    nhanVienService.Add(nhanVien);

                MessageBox.Show("Thêm nhân viên thành công!");
                clearValue();
                this.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                DialogResult res = MessageBox.Show("Dữ liệu chưa được lưu, Bạn có muốn thoát không?", "Hệ thống", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            if(isSave && nhanVien != null)
            {
                txtMaNV.Enabled = false;
                txtMaNV.Text = nhanVien.MaNhanVien;
                txtTenNV.Text = nhanVien.TenNhanVien;
                txtEmail.Text = nhanVien.Email;
                txtDiaChi.Text = nhanVien.DiaChi;
                txtSDT.Text = nhanVien.SoDienThoai;
                //MaChucDanh = "BS1",
                if (nhanVien.GioiTinh == true)
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                //dtNgaySinh.Value = nhanVien.NamSinh.Value;
            }
        }
    }
}
