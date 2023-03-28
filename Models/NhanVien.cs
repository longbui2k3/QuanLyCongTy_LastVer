using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyDuAn.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; } 
        public string HoTen { get; set; } 
        public string ViTri { get; set; }  // Chuc Vu
        public string QueQuan { get; set; }
        public string DanToc { get; set; } 
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; } 
        public string MaPB { get; set; }  // Phong Ban
        public string TinhTrang { get; set; }
        public string Email { get; set; } 
        public string HonNhan { get; set; } 
        public string SoCMND { get; set; } 
        public string NgayCap { get; set; } 

        public string NoiCap { get; set; } 
        public string TonGiao { get; set; } 
        public string NgayVao { get; set; } 
        public string DiaChi { get; set; } 
        public string Facebook { get; set; } 
        public string GhiChu { get; set; } 
        public string Anh { get; set; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string viTri, string queQuan, string danToc, string gioiTinh, string ngaySinh, string sDT, string maPB, string tinhTrang, string email, string honNhan, string soCMND, string ngayCap, string noiCap, string tonGiao, string ngayVao, string diaChi, string facebook, string ghiChu, string anh)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ViTri = viTri;
            QueQuan = queQuan;
            DanToc = danToc;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            MaPB = maPB;
            TinhTrang = tinhTrang;
            Email = email;
            HonNhan = honNhan;
            SoCMND = soCMND;
            NgayCap = ngayCap;
            NoiCap = noiCap;
            TonGiao = tonGiao;
            NgayVao = ngayVao;
            DiaChi = diaChi;
            Facebook = facebook;
            GhiChu = ghiChu;
            Anh = anh;
        }
    }

}
