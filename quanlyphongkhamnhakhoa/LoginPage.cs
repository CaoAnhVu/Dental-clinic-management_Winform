using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyphongkhamnhakhoa
{
    public partial class frmLoginPage : Form
    {
        

        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*if (txtTenDangNhap.Text == "Tên đăng nhập" && txtMatKhau.Text == "Mật khẩu")
            {
                frmManager f = new frmManager();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu bạn nhập không chính xác, hãy nhập lại!");
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }*/

            frmManager f = new frmManager();
            this.Hide();
            f.ShowDialog();


        }


    }
}
