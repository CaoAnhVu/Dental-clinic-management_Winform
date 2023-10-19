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

namespace PKNK_CNPM.Item
{
    public partial class TTThuThuatItem : UserControl
    {
        private readonly ThuThuatService _ttService = new ThuThuatService();
        private LoaiThuThuat loaiThuThuat;
        public TTThuThuatItem(LoaiThuThuat service)
        {
            InitializeComponent();
            this.loaiThuThuat = service;
        }

        private void FillThuThuatCombobox()
        {
            List<ThuThuat> loaiTT =  _ttService.FindTypeById(loaiThuThuat.MaLoaiThuThuat);
            cbLoaiTT.DataSource = loaiTT;
            cbLoaiTT.ValueMember = "MaThuThuat";
            cbLoaiTT.DisplayMember = "TenThuThuat";
        }

        private void TTThuThuatItem_Load(object sender, EventArgs e)
        {
            FillThuThuatCombobox();
        }
    }
}
