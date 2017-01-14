using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGaugeApp
{
    public partial class Form3 : Form
    {


        Image needle;
        int radius_temp = 0;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            needle = Image.FromFile("needle1.png");

        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            drawNeedle(e.Graphics);
            //label3.Text = e.

        }

        public void drawNeedle(Graphics g)
        {

            g.TranslateTransform(245, 245);
            g.RotateTransform(radius_temp);
            g.DrawImage(needle, 0, 0);

            label2.Text = radius_temp.ToString();




        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            radius_temp = trackBar1.Value;
            pic_gauge.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + "  " + e.Y.ToString();
        }






    }
}
