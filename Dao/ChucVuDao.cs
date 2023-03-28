using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Dao
{
    internal class ChucVuDao
    {
        public DBConnection dao = new DBConnection();
        public SqlDataReader DocDuDieuTenChucVu()
        {
            try
            {
                dao.conn.Open();
                string query = "Select TenChucVu from ChucVu inner join PhongBan on ChucVu.MaPhongBan=PhongBan.MaPB";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            return null;
        }
        public SqlDataReader DocDuDieuTenChucVuCoDieuKien(string phongban)
        {
            try
            {
                dao.conn.Open();
                string query = "Select TenChucVu from ChucVu inner join PhongBan on ChucVu.MaPhongBan=PhongBan.MaPB where TenPB=N'{0}'";
                string queryCV = String.Format(query, phongban);
                SqlCommand cmd = new SqlCommand(queryCV, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            return null;
        }
    }
}
