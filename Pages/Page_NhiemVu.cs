using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Models;
namespace QuanLyDuAn.Pages
{
    public partial class Page_NhiemVu : UserControl
    {
        List<User> users = new List<User>();
        public Page_NhiemVu()
        {
            InitializeComponent();
        }

        private void Page_NhiemVu_Load(object sender, EventArgs e)
        {
            GenerateData();
            dataGridViewMain.DataSource = users;
        }
        void GenerateData()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                users.Add(
                    new User
                    {
                        Name = "Long",
                        Photo = null,
                        Amount = random.Next(1000, 10000),
                        Progress = random.Next(0, 100),
                        Deadline = DateTime.Now.AddDays(random.Next(0, 365))
                    });
            };
        }
    }
}
