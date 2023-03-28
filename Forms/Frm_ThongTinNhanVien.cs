using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Pages;
namespace QuanLyDuAn.Forms
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        
        public Frm_ThongTinNhanVien()
        {
            InitializeComponent();
        }
        private static Frm_ThongTinNhanVien fttnv = new Frm_ThongTinNhanVien();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void Frm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            Page_ThongTinCaNhan pttcn = new Page_ThongTinCaNhan(fttnv);
            pttcn.Dock = DockStyle.Fill;
            panel2.Controls.Add(pttcn);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Frm_ThongTinNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
