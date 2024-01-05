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
    public partial class LAPTOP : Form
    {
        
        private int imageIndex = 0;
        private Image[] images = new Image[3]; 
        public LAPTOP()
        {
            InitializeComponent();

            
            images[0] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture.PNG");
            images[1] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture2.PNG");
            images[2] = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Capture3.PNG");

            
            timer1.Interval = 800;

          
            timer1.Tick += Timer1_Tick;

        
            timer1.Start();



            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = totalPages;
            hScrollBar1.Value = currentPage;

            
            hScrollBar1.Scroll += HScrollBar1_Scroll;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
        
            pictureBox13.Image = images[imageIndex];

          
            imageIndex++;
            if (imageIndex >= images.Length)
            {
                imageIndex = 0;
            }
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
           
            MessageBox.Show("Đang hiển thị trang 2" + page);
            macbook kfgfg = new macbook();
                kfgfg.ShowDialog();
           
        } 

        

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox13_Click(object sender, EventArgs e)
        {

               currentPage = hScrollBar1.Value;

            
                ShowPage(currentPage);
        }

        private void LAPTOP_Load(object sender, EventArgs e)
        {

        }
    }
}
