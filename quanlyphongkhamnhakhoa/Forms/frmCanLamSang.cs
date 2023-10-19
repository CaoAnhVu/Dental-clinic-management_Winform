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
