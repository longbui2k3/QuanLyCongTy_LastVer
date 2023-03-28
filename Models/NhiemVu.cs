using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class NhiemVu
    {
        public int MaNhiemVu {get;set;}
        public int MaDuAn { get; set; }

        public string TenNhiemVu { get; set; }
        public string MieuTa { get; set; } 

        public int MaNguoiSoHuu { get; set; }
        public string TinhTrang { get; set; } = "In Progress";
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public DateTime NgayDuocThem { get; set; } = DateTime.Now;

    }
}
