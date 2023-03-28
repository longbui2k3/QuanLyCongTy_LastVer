using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Models
{
    internal class DuAn
    {
        public int MaDA { get; set; }
        public string TenDuAn { get; set; }
        public string MieuTa { get; set; }
        public string TinhTrang { get; set; }
        public int MaNguoiSoHuu { get; set; }
        public byte[] TaiLieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayDuocThem { get; set; } = DateTime.Now;


    }
}
