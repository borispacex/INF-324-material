using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int sumaR, sumaG, sumaB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"C:\ejemplo\lago.png");
            Bitmap bc = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            for (int i=0;i<b.Width;i++)
                for (int j = 0; j < b.Height; j++)
                {
                    c = b.GetPixel(i, j);
                    if ((c.R>2 && c.R<22) && (c.G>32 && c.G<52) && (c.B >56 &&c.B<76))
                        bc.SetPixel(i, j, Color.FromArgb(0, 0, 0));

                    else
                        bc.SetPixel(i, j, Color.FromArgb(c.R,c.G,c.B));
                }
            pictureBox1.Image = b;
            pictureBox2.Image = bc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"C:\ejemplo\lago.png");
            Bitmap bc = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    c = b.GetPixel(i, j);
                    if ((c.R > 124 && c.R < 144) && (c.G > 115 && c.G < 135) && (c.B > 98 && c.B < 118))
                        bc.SetPixel(i, j, Color.FromArgb(0, 0, 0));

                    else
                        bc.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                }
            pictureBox1.Image = b;
            pictureBox2.Image = bc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"C:\ejemplo\lago.png");
            Color c = new Color();
            sumaR = 0;
            sumaG = 0;
            sumaB = 0;
            for (int i = 100; i < 110; i++)
                for (int j = 100; j < 110; j++)
                {
                    c = b.GetPixel(i, j);
                    sumaR = sumaR + c.R;
                    sumaG = sumaG + c.G;
                    sumaB = sumaB + c.B;
                }
            pictureBox1.Image = b;
            sumaR = sumaR / 100;
            sumaG = sumaG / 100;
            sumaB = sumaB / 100;
            MessageBox.Show("R:"+sumaR.ToString()+" G:"+sumaG.ToString()+" B:"+sumaB.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"C:\ejemplo\lago.png");
            Bitmap bc = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            int sumaR1, sumaG1, sumaB1;
            for (int i = 0; i < b.Width-10; i=i+10)
                for (int j = 0; j < b.Height-10; j=j+10)
                {
                    sumaR1=0;
                    sumaG1=0;
                    sumaB1=0;
                    for (int k = i; k < i + 10; k++ )
                        for (int l = j; l < j + 10; l++)
                        {
                            c = b.GetPixel(k, l);
                            sumaR1 = sumaR1 + c.R;
                            sumaG1 = sumaG1 + c.G;
                            sumaB1 = sumaB1 + c.B;    
                        }
                    sumaR1 = sumaR1 / 100;
                    sumaG1 = sumaG1 / 100;
                    sumaB1 = sumaB1 / 100;
                    if ((sumaR1 > sumaR - 20 && sumaR1 < sumaR + 20) && (sumaG1 > sumaG - 20 && sumaG1 < sumaG + 20) && (sumaB1 > sumaB - 20 && sumaB1 < sumaB + 20))
                    {
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                bc.SetPixel(k, l, Color.FromArgb(0,0,0) );
                            }
                    }
                    else
                    {
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = b.GetPixel(k, l);
                                bc.SetPixel(k, l, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }
            pictureBox1.Image = b;
            pictureBox2.Image = bc;
        }

    }
}
