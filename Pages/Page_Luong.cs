using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_Luong : UserControl
    {
        LuongDao ld = new LuongDao();
        public Page_Luong()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ChonThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cb_ChonThang.Items.Add("Tháng " + i + "/" + cb_ChonNam.Text);
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Page_Luong_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_ChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = cb_ChonThang.Text.Split('/');
            int thang = Convert.ToInt32(str[0][str[0].Length - 1].ToString());
            int nam = Convert.ToInt32(str[1]);
            var ds = ld.TimKiemNhanVienTheoThangNam(thang, nam);
            dataGridViewMain.DataSource = ds;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var ds = ld.TimKiemNhanVien(txt_Search.Text);
            dataGridViewMain.DataSource = ds;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Columns.Clear();
            dataGridViewMain.DataSource = ld.DanhSachNhanVien();
        }
    }
}
