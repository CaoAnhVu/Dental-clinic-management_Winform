using PKNK_CNPM;
using PKNK_CNPM.FormCustomer;
using PKNK_CNPM.Forms;
using PKNK_CNPM.FormsSetting;
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

namespace PKNK_CNPM
{
    public partial class frmHomeScreen : Form
    {
        bool sidebarExpand;
        bool customerCollapse;
        bool quanlyCollapse;
        bool settingCollapse;
        //fiedls
        private Random random;
        private Button currentButton;
        private Form activeForm;
        private int tempIndex;
        /*public object SiderbarTimer { get; private set; }*/
        //contruction
        public frmHomeScreen()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Drag form
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
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTitleBar.BackColor = color;
                    panelMenu.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    btnCloseChildForm.BackColor = color;
                }
            }
        }
 
        private void DisableButton()
        {
            foreach (Control previousBtn in sidebar.Controls)
            {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    
            }
        }
        //Show Forms
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
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
            btnDangXuat.BackColor = Color.FromArgb(55, 51, 76);
            btnHoaDon.BackColor = Color.FromArgb(55, 51, 76);
            btnPhieuKham.BackColor = Color.FromArgb(55, 51, 76);
            btnThuoc.BackColor = Color.FromArgb(55, 51, 76);
            btnThongKe.BackColor = Color.FromArgb(55, 51, 76);
            btnDoanhThu.BackColor = Color.FromArgb(55, 51, 76);
            btnDanhSachNhanVien.BackColor = Color.FromArgb(55, 51, 76);
            btnDonXuatNhap.BackColor = Color.FromArgb(55, 51, 76);
            if (currentButton != null)
                currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163))); 
            btnCloseChildForm.Visible = false;
            currentButton = null;


        }
        //Drag Form
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Button Max, close, minimize
        private void btnClosePage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximine_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Maximized;
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
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
            /*OpenChildForm(new PKNK_CNPM.Forms.FormManager(), sender);*/
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
           /* OpenChildForm(new PKNK_CNPM.Forms.FormSetting(), sender);*/
            //set timer interval to lowest to make it smoother 
            SettingTimer.Start();
        }


        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachNV(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void btnDonXuatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonXuatNhap(), sender);
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonThuoc(), sender);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmCanLamSang(), sender);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeVatLieu(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe(), sender);
        }

        private void btnThongTinChung_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmThong(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PKNK_CNPM.Forms.FormCustomer(), sender);
            //set timer interval to lowest to make it smoother 
        }
    }
}
