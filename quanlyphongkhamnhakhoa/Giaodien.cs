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
    public partial class frmManager : Form
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
        /*public object SiderbarTimer { get; private set; }*/
        public frmManager()
        {
            random = new Random();
            InitializeComponent();
        }

        private void SiderbarTimer_Tick_1(object sender, EventArgs e)
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother 
            sidebarTimer.Start();
        }

        private void CustomerTimer_Tick(object sender, EventArgs e)
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

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //set timer interval to lowest to make it smoother 
            CustomerTimer.Start();

        }
        //Set timer Manage
        private void QuanlyTimer_Tick(object sender, EventArgs e)
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

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //set timer interval to lowest to make it smoother 
            QuanlyTimer.Start();
        }

        //setTimer Setting
        private void SettingTimer_Tick(object sender, EventArgs e)
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //set timer interval to lowest to make it smoother 
            SettingTimer.Start();
        }
        //Set Timer Account
        private void AccountTimer_Tick(object sender, EventArgs e)
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //set timer interval to lowest to make it smoother 
            AccountTimer.Start();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender == null)
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        } 
        private void DisableButton()
        {
            foreach(Control previousBtn in sidebar.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(55, 63, 65);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
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

        
    }
}
