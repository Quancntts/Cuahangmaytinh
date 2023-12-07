using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cuahangmaytinh
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = null;// Đối tượng kết nối
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=LAB2-29\MAYAO;Initial Catalog=Quanlymaytinh;Integrated Security=True");
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            string tk = txtTK.Text.Trim();
            string mk = txtMK.Text.Trim();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";

            sqlcmd.Connection = sqlcon;

            SqlDataReader data = sqlcmd.ExecuteReader();

            if(data.Read() == true)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
            }

            data.Close();

        }


        private void btthoat_Click(object sender, EventArgs e)
        {
            gioithieu m = new gioithieu();
            {
                m.ShowDialog();
            }
            Form1 n = new Form1();
            {
                n.Close();
            }
            
            
        }
    }
}
