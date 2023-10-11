﻿using PKNK_CNPM;
using PKNK_CNPM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyphongkhamnhakhoa
{
    public partial class frmHomeScreen : Form
    {
        bool sidebarExpand;
        bool customerCollapse;
        bool quanlyCollapse;
        bool settingCollapse;
        bool accountCollapse;
        //fiedls
        private Random random;
        private Button currentButton;
        private Form activeForm;
        private int tempIndex;
        public frmHomeScreen()
        {
            
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Themecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTitleBar.BackColor = color;
                    panelMenu.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in sidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(55, 63, 65);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }
        //Show Forms
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktoppanel.Controls.Add(childForm);
            this.panelDesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            btnCustomer.BackColor = Color.FromArgb(55, 51, 76);
            btnQuanLy.BackColor = Color.FromArgb(55, 51, 76);
            btnSetting.BackColor = Color.FromArgb(55, 51, 76);
            btnAccount.BackColor = Color.FromArgb(55, 51, 76);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if siderbar is Expand, maximine

                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                //if siderbar is Expand, minimine
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother 
            sidebarTimer.Start();
        }

        //Set Timer các chức năng trong toolBar
       

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.FormCustomer(), sender);
            //set timer interval to lowest to make it smoother 
            CustomerTimer.Start();
        }

        private void CustomerTimer_Tick_1(object sender, EventArgs e)
        {
            if (customerCollapse)
            {
                CustomerContainer.Height += 10;
                if (CustomerContainer.Height == CustomerContainer.MaximumSize.Height)
                {
                    customerCollapse = false;
                    CustomerTimer.Stop();

                }
            }
            else
            {
                CustomerContainer.Height -= 10;
                if (CustomerContainer.Height == CustomerContainer.MinimumSize.Height)
                {
                    customerCollapse = true;
                    CustomerTimer.Stop();

                }

            }
        }
        private void QuanlyTimer_Tick_1(object sender, EventArgs e)
        {
            if (quanlyCollapse)
            {
                QuanlyContainer.Height += 10;
                if (QuanlyContainer.Height == QuanlyContainer.MaximumSize.Height)
                {
                    quanlyCollapse = false;
                    QuanlyTimer.Stop();

                }
            }
            else
            {
                QuanlyContainer.Height -= 10;
                if (QuanlyContainer.Height == QuanlyContainer.MinimumSize.Height)
                {
                    quanlyCollapse = true;
                    QuanlyTimer.Stop();

                }

            }
        }
        private void btnQuanLy_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.FormManager(), sender);
            //set timer interval to lowest to make it smoother 
            QuanlyTimer.Start();
        }

        private void SettingTimer_Tick_1(object sender, EventArgs e)
        {
            if (settingCollapse)
            {
                SettingContainer.Height += 10;
                if (SettingContainer.Height == SettingContainer.MaximumSize.Height)
                {
                    settingCollapse = false;
                    SettingTimer.Stop();

                }
            }
            else
            {
                SettingContainer.Height -= 10;
                if (SettingContainer.Height == SettingContainer.MinimumSize.Height)
                {
                    settingCollapse = true;
                    SettingTimer.Stop();

                }

            }
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.FormSetting(), sender);

            //set timer interval to lowest to make it smoother 
            SettingTimer.Start();
        }

        private void AccountTimer_Tick_1(object sender, EventArgs e)
        {
            if (accountCollapse)
            {
                AccountContainer.Height += 10;
                if (AccountContainer.Height == AccountContainer.MaximumSize.Height)
                {
                    accountCollapse = false;
                    AccountTimer.Stop();

                }
            }
            else
            {
                AccountContainer.Height -= 10;
                if (AccountContainer.Height == AccountContainer.MinimumSize.Height)
                {
                    accountCollapse = true;
                    AccountTimer.Stop();

                }
            }
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.FormAccount(), sender);

            //set timer interval to lowest to make it smoother 
            AccountTimer.Start();
        }

        private void btnKhamTongQuat_Click(object sender, EventArgs e)
        {

        }

        private void btnCanLamSan_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {

        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.dialogThemKhachHang(), sender);
        }
    }
}
