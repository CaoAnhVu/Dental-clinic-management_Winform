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

namespace PKNK_CNPM
{
    public partial class frmLoginPage : Form
    {
        private readonly AuthService authService = new AuthService();
        private bool loadingExpand = false;
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát ứng dụng này không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show("Thoát thành công!");
            }
        }
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if (loadingExpand)
            {
                
                loading.Width += 3;
                if (loading.Width == loading.MaximumSize.Width)
                {
                    loadingTimer.Stop();
                    loadingExpand = false;
                    ShowHomeScreen();
                }
            }
            
        }
        private void ShowHomeScreen()
        {
            frmHomeScreen f = new frmHomeScreen();
            f.ShowDialog();
            clearValue();
            this.Hide();

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            loadingTimer.Tick += loadingTimer_Tick;
            loadingTimer.Start();
            try
            {
                Auth user = authService.Login(txtUsername.Text, txtPassword.Text);
                if (!checkValid())
                    throw new Exception("Nhập đầy đủ kí tự!");
                if (user == null)
                    throw new Exception("Sai tên đăng nhập hoặc mật khẩu");
                loadingExpand = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                loadingTimer.Stop();
            }
        }
        
        private bool checkValid()
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
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

