using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDuAn.Dao
{
    internal class PhongBanDao
    {
        public DBConnection dao = new DBConnection();

        public SqlDataReader DocDuDieuTenPB()
        {
            try
            {
                dao.conn.Open();
                string queryPB = "Select TenPB from PhongBan";
                SqlCommand cmd = new SqlCommand(queryPB, dao.conn);
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
