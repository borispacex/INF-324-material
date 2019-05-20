using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Archivos GIF|*.gif|Archivos jpeg|*.jpg";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != string.Empty)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b;
            b = (Bitmap)pictureBox1.Image;
            Color c = new Color();
            c = b.GetPixel(10,10);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap b;
            b = (Bitmap)pictureBox1.Image;
            Color c = new Color();
            c = b.GetPixel(e.X, e.Y);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b;
            b = (Bitmap)pictureBox1.Image;
            Bitmap bBlue = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            for (int i=0; i<b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    c = b.GetPixel(i,j);
                    bBlue.SetPixel(i, j, Color.FromArgb(0, 0, c.B));
                }
            pictureBox2.Image = bBlue;
        }
    }
}
