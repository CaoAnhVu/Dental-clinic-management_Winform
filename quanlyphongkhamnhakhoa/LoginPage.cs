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

namespace quanlyphongkhamnhakhoa
{
    public partial class frmLoginPage : Form
    {
        private readonly AuthService authService = new AuthService();
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

            try
            {
                Auth user = authService.Login(txtUsername.Text, txtPassword.Text);
                /*if (!checkValid())
                    throw new Exception("Nhập đầy đủ kí tự!");
                if (user == null)
                    throw new Exception("Sai tên đăng nhập hoặc mật khẩu");*/

                frmHomeScreen f = new frmHomeScreen();
                f.ShowDialog();
                MessageBox.Show("Đăng nhập thành công!");
                clearValue();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool checkValid()
        {
            if (txtUsername.Text != "" || txtPassword.Text != "")
            {
                return true;
            }
            return false;
        }

        private void clearValue()
        {
            txtUsername.Text = txtPassword.Text = "";
        }
    }
}

