using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn
{
    public partial class Frm_Main : Form
    {
        private string closeButtonFullPath = "../../Images/close.png";
       
        public Frm_Main()
        {
            InitializeComponent();
        }
        private static Frm_Main frmm = new Frm_Main();

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else 
                WindowState = FormWindowState.Normal;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iconButtonBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            InitialSubMenu();
            panelChevronDown.Visible = false;
        }
        private void InitialSubMenu()
        {
            panelTuyenDung.Visible = false;
            panelNhanSu.Visible = false;
            panelChamCong.Visible = false;
            panelTienLuong.Visible = false;
            panelPhanCongDuAn.Visible = false;
        }

        private void bunifuShapes1_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void hideSubMenu()
        {
            if (panelTuyenDung.Visible == true)
                panelTuyenDung.Visible = false;
            if (panelNhanSu.Visible == true)
                panelNhanSu.Visible = false;
            if (panelChamCong.Visible == true)
                panelChamCong.Visible = false;
            if (panelTienLuong.Visible == true)
                panelTienLuong.Visible = false;
            if (panelPhanCongDuAn.Visible == true)
                panelPhanCongDuAn.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;

        }
        private void ClickToChangeColor(IconButton btn)
        {
            if (btn.ForeColor == Color.Transparent)
                btn.ForeColor = Color.RoyalBlue;
            else btn.ForeColor = Color.Transparent;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.RoyalBlue;
            else btn.BackColor = Color.White;

            if (btn.IconColor == Color.White)
                btn.IconColor = Color.RoyalBlue;
            else btn.IconColor = Color.White;
        }
        private IconButton currIconButton;
        private Page_Luong pl = new Page_Luong();
        private Page_ThongTinCaNhan pttcn = new Page_ThongTinCaNhan(frmm);
        private Page_NhanVien dsnv = new Page_NhanVien();
        private Page_NhiemVu pnv = new Page_NhiemVu();
        private Page_TuyenDung ptd = new Page_TuyenDung();
        private void btn_TienLuong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTienLuong);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_TienLuong;
            ClickToChangeColor(btn_TienLuong);
            
            if (!panelMain.Controls.Contains(pl))
            {
                panelMain.Controls.Clear();
                pl.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pl);
            }
            
        }

        private void btn_TuyenDung_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTuyenDung);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_TuyenDung;
            ClickToChangeColor(btn_TuyenDung);

            if (!panelMain.Controls.Contains(ptd))
            {
                panelMain.Controls.Clear();
                ptd.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ptd);
            }
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            panelChevronDown.Visible = !panelChevronDown.Visible;
                
        }

        private void iconButtonBar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_NhanSu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanSu);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_NhanSu;
            ClickToChangeColor(btn_NhanSu);

        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChamCong);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_ChamCong;
            ClickToChangeColor(btn_ChamCong);
 

        }

        private void btn_PhanCongDuAn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPhanCongDuAn);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_PhanCongDuAn;
            ClickToChangeColor(btn_PhanCongDuAn);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            
            if (!panelMain.Controls.Contains(pttcn))
            {
                panelMain.Controls.Clear();
                pttcn.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pttcn);
            }
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap f = new Frm_DangNhap();
            f.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(pttcn))
            {
                panelMain.Controls.Clear();
                dsnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(dsnv);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(pnv))
            {
                panelMain.Controls.Clear();
                pnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pnv);
            }
        }
    }
}
