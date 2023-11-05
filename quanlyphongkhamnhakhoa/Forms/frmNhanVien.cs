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

namespace PKNK_CNPM.FormsSetting
{
    public partial class frmDanhSachNV : Form
    {
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private NhanVien nhanVien;

        public frmDanhSachNV()
        {
            InitializeComponent();
        }
        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            List<NhanVien> nv =  nhanVienService.GetAll();
            BindGrid(nv);
            txtTong.Text = nv.Count.ToString();
        }

        private void BindGrid(List<NhanVien> list)
        {
            try
            {
                dgvNhanVien.Rows.Clear();
                foreach (NhanVien i in list)
                {
                    int index = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[index].Cells[0].Value = i.MaNhanVien;
                    dgvNhanVien.Rows[index].Cells[1].Value = i.TenNhanVien;
                    if (i.MaChucDanh != null)
                    {
                        dgvNhanVien.Rows[index].Cells[2].Value = i.ChucDanh.TenChucDanh;
                    }
                    dgvNhanVien.Rows[index].Cells[3].Value = i.NamSinh;
                    dgvNhanVien.Rows[index].Cells[4].Value = i.SoDienThoai;
                    dgvNhanVien.Rows[index].Cells[5].Value = i.Email;
                    dgvNhanVien.Rows[index].Cells[6].Value = i.DiaChi;
                    if (i.GioiTinh != null)
                    {
                        dgvNhanVien.Rows[index].Cells[7].Value = i.GioiTinh == true ? "Nam" : "Nữ";
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("BindGrid frmDanhSachNV Ex:" + ex.Message);
            }
        }

        private void dvgDanhSachKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtChucVu.Text = row.Cells[2].Value.ToString();
            nhanVien = nhanVienService.FindById(row.Cells[0].Value.ToString());

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                frmThemNhanVien frm = new frmThemNhanVien(true, nhanVien);
                frm.ShowDialog();
                BindGrid(nhanVienService.GetAll());
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên dưới bản nhân viên!");
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.ShowDialog();
            BindGrid(nhanVienService.GetAll());
            txtTong.Text = nhanVienService.GetAll().Count.ToString(); // reset lại tổng nhân viên
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            BindGrid(nhanVienService.GetAll());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
                BindGrid(nhanVienService.GetAll());
            else
            {
                BindGrid(nhanVienService.SearchByName(txtTimKiem.Text));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(nhanVien != null)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    nhanVienService.Delete(nhanVien);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên dưới bản nhân viên!");
            }
        }
    }
}
