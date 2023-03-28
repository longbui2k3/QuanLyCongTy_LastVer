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
using System.Web.UI.Design;
using System.Windows.Forms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ThongTinCaNhan : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        private Object thongtin;
        public Page_ThongTinCaNhan(Object thongtin)
        {
            InitializeComponent();
            this.thongtin = thongtin;

        }

        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private string MaCV;
        private string MaPB;
        private void Page_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            if (Object.ReferenceEquals(thongtin.GetType(), typeof(Frm_Main)))
            {
                var reader = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
                if (reader.Read())
                {
                    MaCV = reader["ViTri"].ToString().Trim();
                    MaPB = reader["MaPB"].ToString().Trim();
                    txt_MaNV.Text = reader["MaNV"].ToString().Trim();
                    txt_HoVaTen.Text = reader["HoTen"].ToString().Trim();
                    date_NgaySinh.Text = reader["NgaySinh"].ToString().Trim();
                    cb_GioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                    txt_QueQuan.Text = reader["QueQuan"].ToString().Trim();
                    txt_HonNhan.Text = reader["HonNhan"].ToString().Trim();
                    txt_SoCMND.Text = reader["SoCMND"].ToString().Trim();
                    txt_NoiCap.Text = reader["NoiCap"].ToString().Trim();
                    date_NgayCap.Text = reader["NgayCap"].ToString().Trim();
                    txt_DanToc.Text = reader["DanToc"].ToString().Trim();
                    txt_TonGiao.Text = reader["TonGiao"].ToString().Trim();
                    date_NgayVao.Text = reader["NgayVao"].ToString().Trim();
                    txt_TinhTrang.Text = reader["TinhTrang"].ToString().Trim();
                    txt_GhiChu.Text = reader["GhiChu"].ToString().Trim();
                    txt_ViTri.Text = reader["TenChucVu"].ToString().Trim();
                    txt_PhongBan.Text = reader["TenPB"].ToString().Trim();
                    txt_SDT.Text = reader["SoDienThoai"].ToString().Trim();
                    txt_Email.Text = reader["Email"].ToString().Trim();
                    txt_DiaChi.Text = reader["Diachi"].ToString().Trim();
                    txt_Facebook.Text = reader["Facebook"].ToString().Trim();
                    byte[] b = null;
                    b = (byte[])reader["Anh"];
                    pb_Anh.Image = ConvertBinaryToImage(b);
                }
                txt_MaNV.ReadOnly = true;
                txt_HoVaTen.ReadOnly = true;
                date_NgaySinh.Enabled = false;
                cb_GioiTinh.Enabled = false;
                txt_QueQuan.ReadOnly = true;
                txt_HonNhan.ReadOnly = true;
                txt_SoCMND.ReadOnly = true;
                txt_NoiCap.ReadOnly = true;
                date_NgayCap.Enabled = false;
                txt_DanToc.ReadOnly = true;
                txt_TonGiao.ReadOnly = true;
                date_NgayVao.Enabled = false;
                txt_TinhTrang.ReadOnly = true;
                txt_GhiChu.ReadOnly = true;
                txt_ViTri.ReadOnly = true;
                txt_PhongBan.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_Facebook.ReadOnly = true;
                nvd.dao.conn.Close();
            }
            else if (Object.ReferenceEquals(thongtin.GetType(), typeof(Frm_ThongTinNhanVien)))
            {
                var reader = nvd.DocDuDieuNhanVienTuMaNV(Page_NhanVien.MaNV);
                if (reader.Read())
                {
                    MaCV = reader["ViTri"].ToString().Trim();
                    MaPB = reader["MaPB"].ToString().Trim();
                    txt_MaNV.Text = reader["MaNV"].ToString().Trim();
                    txt_HoVaTen.Text = reader["HoTen"].ToString().Trim();
                    date_NgaySinh.Text = reader["NgaySinh"].ToString().Trim();
                    cb_GioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                    txt_QueQuan.Text = reader["QueQuan"].ToString().Trim();
                    txt_HonNhan.Text = reader["HonNhan"].ToString().Trim();
                    txt_SoCMND.Text = reader["SoCMND"].ToString().Trim();
                    txt_NoiCap.Text = reader["NoiCap"].ToString().Trim();
                    date_NgayCap.Text = reader["NgayCap"].ToString().Trim();
                    txt_DanToc.Text = reader["DanToc"].ToString().Trim();
                    txt_TonGiao.Text = reader["TonGiao"].ToString().Trim();
                    date_NgayVao.Text = reader["NgayVao"].ToString().Trim();
                    txt_TinhTrang.Text = reader["TinhTrang"].ToString().Trim();
                    txt_GhiChu.Text = reader["GhiChu"].ToString().Trim();
                    txt_ViTri.Text = reader["TenChucVu"].ToString().Trim();
                    txt_PhongBan.Text = reader["TenPB"].ToString().Trim();
                    txt_SDT.Text = reader["SoDienThoai"].ToString().Trim();
                    txt_Email.Text = reader["Email"].ToString().Trim();
                    txt_DiaChi.Text = reader["Diachi"].ToString().Trim();
                    txt_Facebook.Text = reader["Facebook"].ToString().Trim();
                    byte[] b = null;
                    b = (byte[])reader["Anh"];
                    pb_Anh.Image = ConvertBinaryToImage(b);
                }
                txt_MaNV.ReadOnly = true;
                txt_HoVaTen.ReadOnly = true;
                date_NgaySinh.Enabled = false;
                cb_GioiTinh.Enabled = false;
                txt_QueQuan.ReadOnly = true;
                txt_HonNhan.ReadOnly = true;
                txt_SoCMND.ReadOnly = true;
                txt_NoiCap.ReadOnly = true;
                date_NgayCap.Enabled = false;
                txt_DanToc.ReadOnly = true;
                txt_TonGiao.ReadOnly = true;
                date_NgayVao.Enabled = false;
                txt_TinhTrang.ReadOnly = true;
                txt_GhiChu.ReadOnly = true;
                txt_ViTri.ReadOnly = true;
                txt_PhongBan.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_Facebook.ReadOnly = true;

                nvd.dao.conn.Close();
            }
            


        }
        string imageUrl = null;
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pb_Anh.Image = Image.FromFile(imageUrl);
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Image img = pb_Anh.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            try
            {
                nvd.dao.conn.Open();
                SqlCommand cmd = new SqlCommand("Update NhanVien set Anh = @Image where MaNV = @MaNV", nvd.dao.conn);
                cmd.Parameters.AddWithValue("@Image", arr);
                cmd.Parameters.AddWithValue("@MaNV", txt_MaNV.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");

                SqlCommand cmd2 = new SqlCommand("Select Anh, MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien inner join ChucVu " +
                                "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB", nvd.dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd2.ExecuteReader());
                Page_NhanVien.dataGridViewMainCopy.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                nvd.dao.conn.Close();
            }


            
        }
    }
}
