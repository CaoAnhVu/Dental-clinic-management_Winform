using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using PKNK_CNPM.FormCustomer;
using PKNK_CNPM.FormsSetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKNK_CNPM.Forms
{
    public partial class FormCustomer : Form
    {
        private readonly KhachHangService khachHangService = new KhachHangService();
        private BenhNhan khachHang;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            BindGrid(khachHangService.GetAll());
            setCount();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {   
                    Button btn= (Button)btns;
                    btns.BackColor = Themecolor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                    
                }
            }
        }

        private void setCount()
        {
            txtTong.Text = khachHangService.GetAll().Count.ToString();
        }

        private void clearValue()
        {
            txtMaBN.Text = txtTenBN.Text = txtSDT.Text = txtGioiTinh.Text = txtNamSinh.Text = txtDiaChi.Text = "";
        }
        private void BindGrid(List<BenhNhan> list)
        {
            try
            {
                dvgDanhSachKham.Rows.Clear();
                foreach (BenhNhan i in list)
                {
                    int index = dvgDanhSachKham.Rows.Add();
                    dvgDanhSachKham.Rows[index].Cells[0].Value = i.MaBN;
                    dvgDanhSachKham.Rows[index].Cells[1].Value = i.TenBN;
                    dvgDanhSachKham.Rows[index].Cells[2].Value = i.SDT;
                    dvgDanhSachKham.Rows[index].Cells[3].Value = i.GioiTinh == true ? "Nam" : "Nữ";
                    dvgDanhSachKham.Rows[index].Cells[4].Value = i.NgaySinh;
                    if(i.NhanVien!= null)
                    {
                        dvgDanhSachKham.Rows[index].Cells[5].Value = i.NhanVien.TenNhanVien;
                    }
                    dvgDanhSachKham.Rows[index].Cells[6].Value = i.DiaChi;
                    dvgDanhSachKham.Rows[index].Cells[7].Value = i.NgayTao;
                    dvgDanhSachKham.Rows[index].Cells[8].Value = i.DaThanhToan;
                    dvgDanhSachKham.Rows[index].Cells[9].Value = i.GhiChu;
                    //dvgDanhSachKham.Rows[index].Cells[11].Value = i.TrangThai.TenTrangThai;
                    dvgDanhSachKham.Rows[index].Cells[10].Value = i.HuyetApMach == true ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[11].Value = i.DuongHuyet == true ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[13].Value = i.MauKhoDong == true ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[14].Value = i.BenhTimBamSinh == true ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[15].Value = i.ThieuNangTriTue == true ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[16].Value = i.XQuang != "" ? "Có" : "Không";
                    dvgDanhSachKham.Rows[index].Cells[17].Value = i.MaBaoHiem;
                    dvgDanhSachKham.Rows[index].Cells[18].Value = i.Khac;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BindGrid frmDanhSachNV Ex:" + ex.Message);
            }
        }

        private void dvgDanhSachKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dvgDanhSachKham.Rows[e.RowIndex];
            txtMaBN.Text = row.Cells[0].Value.ToString();
            txtTenBN.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtGioiTinh.Text = row.Cells[3].Value.ToString();
            txtNamSinh.Text = String.Format("{0:dd/MM/yyyy}", row.Cells[4].Value);
            if (row.Cells[5].Value.ToString() != "")
                txtDiaChi.Text = row.Cells[5].Value.ToString();
            khachHang = khachHangService.FindById(int.Parse(row.Cells[0].Value.ToString()));
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmKH = new frmThemKhachHang();
            frmKH.ShowDialog();
            BindGrid(khachHangService.GetAll());
            setCount();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            BindGrid(khachHangService.GetAll());
            clearValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frmThemKhachHang frm = new frmThemKhachHang(true, khachHang);
                frm.ShowDialog();
                BindGrid(khachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng dưới bản khách hàng!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    khachHangService.Remove(khachHang);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng dưới bản khách hàng!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                BindGrid(khachHangService.GetAll());
            else
            {
                BindGrid(khachHangService.SearchByName(txtTimKiem.Text));
            }
        }

        private void btnKhamLamSan_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frmCanLamSang frmCanLamSang = new frmCanLamSang(khachHang);
                frmCanLamSang.ShowDialog();
                BindGrid(khachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng dưới bản khách hàng!");
            }
        }

        private void btnCanLamSan_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frmKhamLamSan frmKhamLamSan = new frmKhamLamSan(khachHang);
                frmKhamLamSan.ShowDialog();
                BindGrid(khachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng dưới bản khách hàng!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
