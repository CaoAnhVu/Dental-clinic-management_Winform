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

namespace PKNK_CNPM.FormsSetting
{
    public partial class frmDanhSachNV : Form
    {
        public frmDanhSachNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindGrid(List<NhanVien> list)
        {
            //dtgvEmployee.Rows.Clear();
            //foreach (BacSi i in list)
            //{
            //    int index = dtgvEmployee.Rows.Add();
            //    dtgvEmployee.Rows[index].Cells[0].Value = i.MaBS;
            //    dtgvEmployee.Rows[index].Cells[1].Value = i.TenBacSi;
            //    //if (i.GioiTinh != null)
            //    //{
            //    //    dtgvEmployee.Rows[index].Cells[2].Value = i.GioiTinh == 0;
            //    //}
            //    //dtgvEmployee.Rows[index].Cells[3].Value = i.AvgScore;
            //    //if (i.MajorID != null)
            //    //{
            //    //    dtgvEmployee.Rows[index].Cells[4].Value = i.Major.Name;
            //    //}
            //}
        }
    }
}
