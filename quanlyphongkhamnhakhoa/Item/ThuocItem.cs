using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PKNK_CNPM.FormCustomer.Controller
{
    public partial class ThuocItem : UserControl
    {
        #region Properties
        private string _uid;
        private string _title;
        private string _price;
        private System.Drawing.Image _imagePath;

        [Category("Custom Props")]
        public string UID
        {
            get { return _uid; }
            set { _uid = value;}
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lbDonGia.Text = $"Giá: {value} VNĐ"; }
        }
        [Category("Custom Props")]
        public System.Drawing.Image ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; pictureBox14.Image = value; }
        }
        #endregion
        public ThuocItem()
        {
            InitializeComponent();
        }
    }
}
