using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyDuAn.Models;
using System.Windows.Controls;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace QuanLyDuAn.Dao.Dao
{
    internal class NhanVienDao
    {
        public DBConnection dao = new DBConnection();
        private DataTable LayDuLieu(string query, string ob, string ob2)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = string.Format(query, ob, ob2);

                if (dao.DanhSach(query).Rows.Count > 0)
                {
                    return dao.DanhSach(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
        }
        
        private void ThucThiLenh(string query, NhanVien nv)
        {
            try
            {
                dao.conn.Open();
               
                string sqlStr = String.Format(query, nv.MaNV, nv.HoTen, nv.ViTri, nv.QueQuan, nv.DanToc, nv.GioiTinh, nv.NgaySinh, nv.SDT,
                    nv.MaPB, nv.TinhTrang, nv.Email, nv.HonNhan, nv.SoCMND, nv.NgayCap, nv.NoiCap, nv.TonGiao, nv.NgayVao, nv.DiaChi
                    ,nv.Facebook, nv.GhiChu, nv.Anh);

                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        
        public DataTable DanhSachNhanVien()
        {
            try
            {
                dao.conn.Open();
                string query = "Select Anh, MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien inner join ChucVu " +
                                    "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
           

            //return LayDuLieu(query, "", "");
        }
        public DataTable TimKiemNhanVien(string search)
        {
            string query = "SELECT MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao" +
                               "FROM (Select * from NhanVien inner join ChucVu " +
                                "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PHONGBAN on k.MaPB=PhongBan.MaPB WHERE " + "HoTen LIKE N'%{0}%'";
            return LayDuLieu(query, "", "");
        }
        public void CapNhatNhanVien(NhanVien nv)
        {
            string query = "Update NhanVien set HoTen=N'{1}', " +
            "ViTri=N'{2}', " +
            "QueQuan=N'{3}', " +
            "DanToc=N'{4}', " +
            "GIoiTinh=N'{5}', " +
            "NgaySinh='{6}', " +
            "SoDienTHoai='{7}', " +
            "MaPB=N'{8}', " +
            "TinhTrang=N'{9}', " +
            "Email=N'{10}', " +
            "HonNhan=N'{11}', " +
            "SoCMND=N'{12}', " +
            "NgayCap=N'{13}', " +
            "NoiCap=N'{14}', " +
            "TonGiao=N'{15}', " +
            "NgayVao=N'{16}', " +
            "DiaChi=N'{17}', " +
            "Facebook=N'{18}', " +
            "GhiChu=N'{19}', " +
            "Anh=N'{20}' where MaNV = '{0}'";
            ThucThiLenh(query, nv);
        }
        public SqlDataReader DocDuDieuNhanVienTuTK(string username, string password)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from (Select * " +
                                "from TKTruongPhong inner join NhanVien " +
                                "on TKTruongPhong.MaTP = NhanVien.MaNV where Username = '{0}' and Pass_word = '{1}') p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                string sqlStr = String.Format(query, username, password);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public SqlDataReader DocDuDieuNhanVienTuMaNV(string MaNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where MaNV ='{0}'";
                string sqlStr = String.Format(query, MaNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public DataTable DocDuDieuNhanVienTuPhongBan(string phongBan)
        {
            try
            {
                dao.conn.Open();
                string query = "Select Anh,MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "'";
                
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;



        }
        public DataTable DocDuDieuNhanVienTuPhongBanVaChucVu(string phongBan, string chucVu)
        {
            
            try
            {
                dao.conn.Open();
                string query = "Select Anh,MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                               "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "' and TenChucVu = N'" + chucVu + "'";

                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
        }
        public DataTable DocDuDieuNhanVienTuTinhTrang(string tinhtrang)
        {
            
            try
            {
                dao.conn.Open();
                string query = "Select Anh,MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                               "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TinhTrang=N'" + tinhtrang + "'";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
        }

        public DataTable XoaNhanVien(object ob)
        {
            try
            {
                dao.conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV='{0}'";
                string sqlStr = string.Format(query, ob);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return this.DanhSachNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
        }
    }
}
