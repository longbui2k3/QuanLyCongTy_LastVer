using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class Luong
    {
        public NhanVien MaNV { get; set; }
        public string HoTen { get; set; }
        public string PhongBan { get; set; }
        public string ViTri { get; set; }
        public int NgayCong { get; set; }
        public int LuongViTri { get; set; }
        public int SoCongChuan { get; set; }
        public int LuongThucTe { get; set; }
        public int LuongPhuCap { get; set; }
        public int Thuong { get; set; }
        public int KhauTru { get; set; }
        public int TamUng { get; set; }
        public int ThucNhan { get; set; }
        public int ThangLamViec { get; set; }
        public int NamLamViec { get; set; }
        public Luong()
        {

        }
        public Luong(NhanVien maNV, string hoTen, string phongBan, string viTri, int ngayCong, int luongViTri, int soCongChuan, int luongThucTe, int luongPhuCap, int thuong, int khauTru, int tamUng, int thucNhan, int thangLamViec, int namLamViec)
        {
            MaNV = maNV;
            HoTen = hoTen;
            PhongBan = phongBan;
            ViTri = viTri;
            NgayCong = ngayCong;
            LuongViTri = luongViTri;
            SoCongChuan = soCongChuan;
            LuongThucTe = luongThucTe;
            LuongPhuCap = luongPhuCap;
            Thuong = thuong;
            KhauTru = khauTru;
            TamUng = tamUng;
            ThucNhan = thucNhan;
            ThangLamViec = thangLamViec;
            NamLamViec = namLamViec;
        }
    }
}
