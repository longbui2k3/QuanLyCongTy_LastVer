using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NhanVien : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        PhongBanDao pbd = new PhongBanDao();
        ChucVuDao cvd = new ChucVuDao();
        public static BunifuDataGridView dataGridViewMainCopy;
        public static string MaNV;
        public Page_NhanVien()
        {
            InitializeComponent();
            dataGridViewMainCopy = dataGridViewMain;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];
                MaNV = row.Cells[2].Value.ToString();
                Frm_ThongTinNhanVien frmttnv = new Frm_ThongTinNhanVien();
                frmttnv.Show();
            }
        }
        void HienThiDSNhanVien()
        {
            dataGridViewMain.DataSource = nvd.DanhSachNhanVien();
        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void Page_NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            SqlDataReader cotTenPB = pbd.DocDuDieuTenPB();
            cb_PhongBan.Items.Add("Phòng Ban (Tất Cả)");
            while (cotTenPB.Read())
                cb_PhongBan.Items.Add(cotTenPB["TenPB"].ToString().Trim());
            pbd.dao.conn.Close();

            SqlDataReader cotTenCV = cvd.DocDuDieuTenChucVu();
            cb_ViTri.Items.Add("Vị Trí (Tất Cả)");

            if (cotTenCV != null)
            {
                while (cotTenCV.Read())
                    cb_ViTri.Items.Add(cotTenCV["TenChucVu"].ToString().Trim());
            }
            cvd.dao.conn.Close();
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            var ds = nvd.TimKiemNhanVien(txt_Search.Text);
            dataGridViewMain.DataSource = ds;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var ds = nvd.XoaNhanVien(txt_Search.Text);
            dataGridViewMain.DataSource = ds;
        }
        private void cb_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phongBanDuocChon = cb_PhongBan.Text;
            cb_ViTri.Items.Clear();
            SqlDataReader cotTenCV;
            if (phongBanDuocChon == "Phòng Ban (Tất Cả)")
            {
                cotTenCV = cvd.DocDuDieuTenChucVu();
            }
            else
            {
                cotTenCV = cvd.DocDuDieuTenChucVuCoDieuKien(phongBanDuocChon);
            }
            cb_ViTri.Items.Add("Vị Trí (Tất Cả)");
            cb_ViTri.Text = "Vị Trí (Tất Cả)";

            if (cotTenCV != null)
            {
                while (cotTenCV.Read())
                    cb_ViTri.Items.Add(cotTenCV["TenChucVu"].ToString().Trim());
            }
            cvd.dao.conn.Close();

            string viTri = cb_ViTri.Text;
            if (viTri == "Vị Trí (Tất Cả)" && cb_PhongBan.Text == "Phòng Ban (Tất Cả)")
            {
                HienThiDSNhanVien();
            }
            else if (viTri == "Vị Trí (Tất Cả)")
            {
                var ds = nvd.DocDuDieuNhanVienTuPhongBan(cb_PhongBan.Text.Trim());
                dataGridViewMain.DataSource = ds;
            }
            else
            {
                var ds = nvd.DocDuDieuNhanVienTuPhongBanVaChucVu(cb_PhongBan.Text, cb_ViTri.Text);
                dataGridViewMain.DataSource = ds;

            }
        }

        private void cb_ViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viTri = cb_ViTri.Text;
            if (viTri == "Vị Trí (Tất Cả)" && cb_PhongBan.Text == "Phòng Ban (Tất Cả)")
            {
                HienThiDSNhanVien();
            }
            else if (viTri == "Vị Trí (Tất Cả)")
            {
                var ds = nvd.DocDuDieuNhanVienTuPhongBan(cb_PhongBan.Text);
                dataGridViewMain.DataSource = ds;
            }
            else
            {
                var ds = nvd.DocDuDieuNhanVienTuPhongBanVaChucVu(cb_PhongBan.Text, cb_ViTri.Text);
                dataGridViewMain.DataSource = ds;

            }
        }

        private void cb_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = nvd.DocDuDieuNhanVienTuTinhTrang(cb_TinhTrang.Text);
            dataGridViewMain.DataSource = ds;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
