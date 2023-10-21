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

namespace PKNK_CNPM.FormCustomer.Controller
{
    public partial class ThuThuatItem : UserControl
    {
        #region Properties
        private string _title;
        private string _description;
        private Image _imagePath;
        private LoaiThuThuat _tt;

        [Category("Custom Props")]
        public string Title
        {
            get{ return _title; }
            set{ _title = value; lbId.Text = value; }
        }
        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbTitle.Text = value; }

        }
        [Category("Custom Props")]
        public Image ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; pbImage.Image = value; }
        }

        public LoaiThuThuat LoaiThuThuat
        {
            get { return _tt; }
            set { _tt = value;}
        }
        #endregion

        public ThuThuatItem()
        {
            InitializeComponent();
        }

    }
}
