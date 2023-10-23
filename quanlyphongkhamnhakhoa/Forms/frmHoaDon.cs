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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void BindGrid(List<NhanVien> list)
        {
            //try
            //{
            //    dgvNhanVien.Rows.Clear();
            //    foreach (NhanVien i in list)
            //    {
            //        int index = dgvNhanVien.Rows.Add();
            //        dgvNhanVien.Rows[index].Cells[0].Value = i.MaNhanVien;
            //        dgvNhanVien.Rows[index].Cells[1].Value = i.TenNhanVien;
            //        if (i.MaChucDanh != null)
            //        {
            //            dgvNhanVien.Rows[index].Cells[2].Value = i.ChucDanh.TenChucDanh;
            //        }
            //        dgvNhanVien.Rows[index].Cells[3].Value = i.NamSinh;
            //        dgvNhanVien.Rows[index].Cells[4].Value = i.SoDienThoai;
            //        dgvNhanVien.Rows[index].Cells[5].Value = i.Email;
            //        dgvNhanVien.Rows[index].Cells[6].Value = i.DiaChi;
            //        if (i.GioiTinh != null)
            //        {
            //            dgvNhanVien.Rows[index].Cells[7].Value = i.GioiTinh == true ? "Nam" : "Nữ";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("BindGrid frmDanhSachNV Ex:" + ex.Message);
            //}
        }

    }
}
