using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDuAn.Dao.Dao
{
    internal class LuongDao
    {
        DBConnection dao = new DBConnection();
        private DataTable LayDuLieu(string query, object ob1, object ob2)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = string.Format(query, ob1, ob2);
                if (dao.DanhSach(query).Rows.Count > 0)
                    return dao.DanhSach(query);

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
        public DataTable TimKiemNhanVien(string ob)
        {
            string query = "SELECT MaNhanVien, " +
                                        "HoVaTen , " +
                                        "PhongBan , " +
                                        "ViTri , " +
                                        "LuongViTri , " +
                                        "LuongPhuCap , " +
                                        "NgayCong , " +
                                        "SoCongChuan , " +
                                        "LuongThucTe ," +
                                        "Thuong , " +
                                        "KhauTru ," +
                                        "TamUng , " +
                                        "ThucNhan FROM LUONG WHERE MaNhanVien='{0}'";
            return LayDuLieu(query, ob, "");
        }
        public DataTable TimKiemNhanVienTheoThangNam(int thang, int nam)
        {
            string query = "SELECT MaNhanVien, " +
                                        "HoVaTen , " +
                                        "PhongBan , " +
                                        "ViTri , " +
                                        "LuongViTri , " +
                                        "LuongPhuCap , " +
                                        "NgayCong , " +
                                        "SoCongChuan , " +
                                        "LuongThucTe ," +
                                        "Thuong , " +
                                        "KhauTru ," +
                                        "TamUng , " +
                                        "ThucNhan FROM LUONG WHERE ThangLamViec = " + thang + " and NamLamViec = " + nam;

            return LayDuLieu(query, thang, nam);
        }
        public DataTable DanhSachNhanVien()
        {
            string query = "SELECT MaNhanVien, " +
                                        "HoVaTen , " +
                                        "PhongBan , " +
                                        "ViTri , " +
                                        "LuongViTri , " +
                                        "LuongPhuCap , " +
                                        "NgayCong , " +
                                        "SoCongChuan , " +
                                        "LuongThucTe ," +
                                        "Thuong , " +
                                        "KhauTru ," +
                                        "TamUng , " +
                                        "ThucNhan FROM LUONG";
            return LayDuLieu(query, "", "");
        }
        public DataTable XoaNhanVien(object ob)
        {
            try
            {
                dao.conn.Open();
                string query = "DELETE FROM LUONG WHERE MaNhanVien='{0}'";
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
