using PKNK.BUS.Servive;
using PKNK.DAL.Models;
using PKNK_CNPM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PKNK_CNPM.FormCustomer
{
    public partial class frmKhamLamSan : Form
    {
        private readonly TTCanLamSangService ttCanLamSangService = new TTCanLamSangService();
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly KhachHangService khachHangService = new KhachHangService();
        private BenhNhan khachHang;
        private TTCanLamSan tTCanLamSan;

        public frmKhamLamSan(BenhNhan khachHang)
        {
            this.khachHang = khachHang;

            InitializeComponent();
        }

        private void FillNhanVienCombobox(List<NhanVien> list)
        {
            list.Insert(0, new NhanVien());
            this.cbNhanVien.DataSource = list;
            this.cbNhanVien.DisplayMember = "TenNhanVien";
            this.cbNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadComboBox()
        {
            foreach (var item in cbNhanVien.Items)
            {
                if (((NhanVien)item).MaNhanVien == tTCanLamSan.MaNV)
                {
                    cbNhanVien.SelectedItem = item;
                    break;
                }
            }
        }

        private void loadValue()
        {
            tTCanLamSan = ttCanLamSangService.FindByMaBN(khachHang.MaBN);
            txtMaKH.Text = khachHang.MaBN.ToString();
            txtTenKhachHang.Text = khachHang.TenBN.ToString();
            txtMaPhieu.Text = tTCanLamSan.MaPhieuKham;
            cbGan.Checked = tTCanLamSan.Gan.Value;
            cbTieuDuong.Checked = tTCanLamSan.TieuDuong.Value;
            cbThapKop.Checked = tTCanLamSan.ThapKhop.Value;
            cbThanKinh.Checked = tTCanLamSan.ThanKinh.Value;
            cbDiUng.Checked = tTCanLamSan.DiUng.Value;
            cbTieuHoa.Checked = tTCanLamSan.TieuHoa.Value;
            cbHoHap.Checked = tTCanLamSan.HoHap.Value;
            cbTimMach.Checked = tTCanLamSan.TimMach.Value;
            cbThan.Checked = tTCanLamSan.ThanKinh.Value;
            cbKopThaiDuong.Checked = tTCanLamSan.KhopThaiDuongHam.Value;
            cbDaNhoRang.Checked = tTCanLamSan.DaTungNhoRang.Value;
            cbDaChinhNha.Checked = tTCanLamSan.DaTungChinhNha.Value;
            rtbGhiChu.Text = tTCanLamSan.Khac;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void frmKhamLamSan_Load_1(object sender, EventArgs e)
        {
            FillNhanVienCombobox(nhanVienService.GetAll());
            loadValue();
            loadComboBox();
        }

        private void btnLuuLai_Click_1(object sender, EventArgs e)
        {
            try
            {
                NhanVien selectedNhanVien = (NhanVien)cbNhanVien.SelectedItem;
                if (selectedNhanVien.TenNhanVien == "")
                    throw new Exception("Chưa chọn nhân viên!");
                if((cbKhac.Checked || cbKhac2.Checked) && rtbGhiChu.Text == "")
                    throw new Exception("Ấn vào khác phải thêm ghi chú!");

                TTCanLamSan value = new TTCanLamSan()
                {
                    MaPhieuKham = txtMaPhieu.Text,
                    MaBN = int.Parse(txtMaKH.Text),
                    MaNV = selectedNhanVien.MaNhanVien,
                    NgayTao = DateTime.Now,
                    Gan = cbGan.Checked,
                    TieuDuong = cbTieuDuong.Checked,
                    ThapKhop = cbThapKop.Checked,
                    DiUng = cbDiUng.Checked,
                    TieuHoa = cbTieuHoa.Checked,
                    HoHap = cbHoHap.Checked,
                    TimMach = cbTimMach.Checked,
                    Than = cbThan.Checked,
                    ThanKinh = cbThanKinh.Checked,
                    KhopThaiDuongHam = cbKopThaiDuong.Checked,
                    DaTungNhoRang = cbDaNhoRang.Checked,
                    DaTungChinhNha = cbDaChinhNha.Checked,
                    DaTungDeoHam = cbDaDeoHam.Checked,
                    Khac = rtbGhiChu.Text,
                };

                BenhNhan khachHang = khachHangService.FindById(int.Parse(txtMaKH.Text));
                if(khachHang.MaTrangThai == "TT001")
                    khachHang.MaTrangThai = "TT002";

                khachHangService.Update(khachHang);
                ttCanLamSangService.Update(value);
                MessageBox.Show("Cập nhật thông tin khám cận lâm sàng khách hàng thành công!");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHoSoPhongKham_Click_1(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frmThemKhachHang frm = new frmThemKhachHang(true, khachHang);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng dưới bản khách hàng!");
            }
        }
    }
}