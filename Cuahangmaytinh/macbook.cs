using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cuahangmaytinh
{
    public partial class macbook : Form
    {
        private int imageIndex = 0;
        private Image[] images = new Image[3];
        public macbook()
        {
            InitializeComponent();
            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = totalPages;
            hScrollBar1.Value = currentPage;


            hScrollBar1.Scroll += HScrollBar1_Scroll;
            
            
            
            
        images[0] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture4.PNG");
        images[1] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture5.PNG");
        images[2] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture6.PNG");


        timer1.Interval = 800;


        timer1.Tick += timer1_Tick;


        timer1.Start();
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
       
            MessageBox.Show("Đang hiển thị trang 3" + page);
            tainghe dhjs = new tainghe();
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