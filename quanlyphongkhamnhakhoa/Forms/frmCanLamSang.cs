using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKNK_CNPM.FormCustomer
{
    public partial class frmCanLamSang : Form
    {
        public frmCanLamSang()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======
        private void populateThuThuatItems()
        {
            List<LoaiThuThuat> thuThuats = loaiThuThuatService.GetAll();
            ThuThuatItem[] thuThuatItems = new ThuThuatItem[thuThuats.Count];
            for(int i = 0; i < thuThuatItems.Length; i++)
            {
                thuThuatItems[i] = new ThuThuatItem();
                thuThuatItems[i].Title = thuThuats[i].MaLoaiThuThuat;
                thuThuatItems[i].Description = thuThuats[i].TenLoaiThuThuat;
                thuThuatItems[i].Price = "";
                thuThuatItems[i].Cursor = Cursors.Hand;
                if (flpThuThuat.Controls.Count < 0)
                {
                    flpThuThuat.Controls.Clear();
                }
                else
                {
                    flpThuThuat.Controls.Add(thuThuatItems[i]);
                }
                thuThuatItems[i].Click += (sender, e) => ThuThuatControl_Click(this, e, thuThuats[i]);
            }
        }

        private void populateThuocItems()
        {
            List<Thuoc> thuocs = thuocService.GetAll();
            ThuocItem[] thuocItems = new ThuocItem[thuocs.Count];
            for (int i = 0; i < thuocItems.Length; i++)
            {
                var ThuocItem = new ThuocItem
                {
                    Title = thuocs[i].TenThuoc,
                    Price = thuocs[i].DonGia.ToString(),
                    Cursor = Cursors.Hand,
                };
                if (flpThuoc.Controls.Count < 0)
                {
                    flpThuoc.Controls.Clear();
                }
                else
                {
                    flpThuoc.Controls.Add(ThuocItem);
                }
            }
        }

        private void populateNhanVienCombobox()
        {
            List<NhanVien> list = nhanVienService.GetAll();
            cbNhanVien.DataSource = list;
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadValue()
        {
            if(khachHang != null)
            {
                txtMaKH.Text = khachHang.MaBN.ToString();
                txtTenKH.Text = khachHang.TenBN;
            }
        }

        void ThuThuatControl_Click(object sender, EventArgs e, LoaiThuThuat ltt) {
            ThuThuatItem thuThuatItem = (ThuThuatItem)sender;
            flpThemThuThuat.Controls.Add(new ThongTinItems());
            flpThemThuThuat.Controls.Add(new TTThuThuatItem(ltt));
        }

        private void frmCanLamSang_Load(object sender, EventArgs e)
        {
            populateNhanVienCombobox(); 
            populateThuThuatItems();
            populateThuocItems();
            loadValue();
        }

        private void btnHoSoPhongKham_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmThemKhach = new frmThemKhachHang(true, khachHang);
            frmThemKhach.ShowDialog();
        }

>>>>>>> parent of 4b2ebbb (update frmLamSang)
        private void btnDonThuoc_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txtNhanVien.Text.Length < 1)
            {
                // Hiển thị thông báo lỗi
                errorProvider1.SetError(txtNhanVien, "Vui lòng nhập ít nhất 1 ký tự.");
            }
            else
            {
                // Xóa thông báo lỗi nếu có
                errorProvider1.Clear();
            }
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachHang.Text.Length < 1)
            {
                // Hiển thị thông báo lỗi
                errorProvider2.SetError(txtKhachHang, "Vui lòng nhập ít nhất 1 ký tự.");
            }
            else
            {
                // Xóa thông báo lỗi nếu có
                errorProvider2.Clear();
            }
        }
    }
}
