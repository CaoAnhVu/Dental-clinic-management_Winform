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
        bool homeCollapse;
        /*public object SiderbarTimer { get; private set; }*/

        public frmManager()
        {
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

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if(homeCollapse)
            {
                HomeContainer.Height += 10;
                if(HomeContainer.Height ==  HomeContainer.MaximumSize.Height)
                {
                    homeCollapse = false;
                    HomeTimer.Stop();

                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if(HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapse = true;
                    HomeTimer.Stop();

                }

            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother 
            HomeTimer.Start();
        }

        
    }   
}
