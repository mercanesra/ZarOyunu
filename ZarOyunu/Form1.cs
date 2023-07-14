using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);
            toplamben = toplamben + a + b;
            label17.Text = toplamben.ToString();
            label2.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            toplampc = toplampc + c + d;
            label15.Text = toplampc.ToString();
            label11.Text = c.ToString();
            label9.Text = d.ToString();

            if(toplamben >50 && toplamben > toplampc)
            {
                label13.Text = "Kazanan sizsizniz Tebrikler";
            }

            if(toplampc >50 && toplampc > toplamben)
            {
                label13.Text = "Kazanan bilgisayar siz kaybettiniz";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
