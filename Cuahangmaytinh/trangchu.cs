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
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = totalPages;
            hScrollBar1.Value = currentPage;

          
            hScrollBar1.Scroll += HScrollBar1_Scroll;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
           
            MessageBox.Show("Đang hiển thị trang 5" + page);
            LAPTOP nqd = new LAPTOP();
            nqd.ShowDialog();
        }

        }
 }
