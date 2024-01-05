using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuahangmaytinh
{
    public partial class tainghe : Form
    {
        private int imageIndex = 0;
        private Image[] images = new Image[3];
        public tainghe()
        {
            InitializeComponent();
            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = totalPages;
            hScrollBar1.Value = currentPage;


            hScrollBar1.Scroll += HScrollBar1_Scroll;




            images[0] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture7.PNG");
            images[1] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture8.PNG");
            images[2] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture9.PNG");


            timer1.Interval = 800;


            timer1.Tick += timer1_Tick;


            timer1.Start();
        }

        private void tainghe_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            {
                int pageNumber = hScrollBar1.Value;
            }
        }
            private int currentPage = 1;
            private int totalPages = 10;

            private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            currentPage = hScrollBar1.Value;


            ShowPage(currentPage);
        }
        private void ShowPage(int page)
        {

            MessageBox.Show("Đang hiển thị trang 4" + page);
            trangchu dhjs = new trangchu();
            dhjs.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = images[imageIndex];


            imageIndex++;
            if (imageIndex >= images.Length)
            {
                imageIndex = 0;
            }
        }

    }
}
