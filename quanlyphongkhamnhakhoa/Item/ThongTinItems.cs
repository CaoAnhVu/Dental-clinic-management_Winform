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
    public partial class ThongTinItems : UserControl
    {
        public ThongTinItems()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            lbLoai.Text = "Loại";
            lbNgayKham.Text = "Ngày khám";
            lbChuanDoan.Text = "Chuẩn đoán";
            lbThuThuat.Text = "Thủ thuật";
            lbBacSi.Text = "Bác sĩ";
            lbNoiDung.Text = "Nội dung";
            lbVatLieu.Text = "Vật liệu";
            lbSL.Text = "SL";
            lbGG.Text = "GG%";
            lbDonGia.Text = "Đơn giá";
            lbThanhTien.Text = "Thành tiền";
            lbKhoa.Text = "Khóa";
        }

        private void ThongTinItems_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
