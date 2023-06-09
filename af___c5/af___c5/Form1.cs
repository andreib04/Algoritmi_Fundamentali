﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace af___c5
{
    public partial class Form1 : Form
    {
        Bitmap sursa, destinatie;

        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for(int i = 0; i < sursa.Width; i++)
            {
                for(int j = 0; j < sursa.Height; j++)
                {
                    Color t = sursa.GetPixel(i, j);

                    destinatie.SetPixel(i, j, t);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);

                    int t = (Old.R + Old.G + Old.B) / 3;
                    Color New = Color.FromArgb(t, t, t);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 70;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);

                    
                    int nr = Old.R - k;
                    if (nr < 0)
                        nr = 0;
                    int ng = Old.G - k;
                    if (ng < 0)
                        ng = 0;
                    int nb = Old.B - k;
                    if (nb < 0)
                        nb = 0;

                    Color New = Color.FromArgb(nr, ng, nb);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = 50;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);

                    int nr = Old.R + k;
                    if (nr > 255)
                        nr = 255;
                    int ng = Old.G + k;
                    if (ng > 255)
                        ng = 255;
                    int nb = Old.B + k;
                    if (nb > 255)
                        nb = 255;

                    Color New = Color.FromArgb(nr, ng, nb);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = 30;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    int nr;
                    int ng;
                    int nb;
                    Color Old = sursa.GetPixel(i, j);
                    int t = (Old.R + Old.G + Old.B) / 3;

                    if (t < 127)
                    {
                         nr = Old.R - k;
                        if (nr < 0)
                            nr = 0;
                         ng = Old.G - k;
                        if (ng < 0)
                            ng = 0;
                         nb = Old.B - k;
                        if (nb < 0)
                            nb = 0;
                    }
                    else
                    {
                         nr = Old.R + k;
                        if (nr > 255)
                            nr = 255;
                         ng = Old.G + k;
                        if (ng > 255)
                            ng = 255;
                         nb = Old.B + k;
                        if (nb > 255)
                            nb = 255;
                    } 

                    Color New = Color.FromArgb(nr, ng, nb);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int k = 100;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);

                    int nr, ng, nb;
                    int t = (Old.R + Old.G + Old.B) / 3;

                    nr = (Old.R + k) % 255;
                    ng = (Old.G + k) % 255;
                    nb = (Old.B + k) % 255;

                    Color New = Color.FromArgb(nr, ng, nb);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width * 2 - 1, sursa.Height * 2 - 1);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);
                    
                    destinatie.SetPixel(i * 2, j * 2, Old);
                }
            }

            for(int i = 0; i < destinatie.Width; i+= 2)
            {
                for(int j = 1; j < destinatie.Height; j+= 2)
                {
                    Color t1 = destinatie.GetPixel(i, j - 1);
                    Color t2 = destinatie.GetPixel(i, j + 1);
                    int r = (t1.R + t2.R) / 2;
                    int g = (t1.G + t2.G) / 2;
                    int b = (t1.B + t2.B) / 2;
                    destinatie.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            for(int i = 1; i < destinatie.Width; i += 2)
            {
                for(int j = 0; j < destinatie.Height; j++)
                {
                    Color t1 = destinatie.GetPixel(i - 1, j);
                    Color t2 = destinatie.GetPixel(i + 1, j);
                    int r = (t1.R + t2.R) / 2;
                    int g = (t1.G + t2.G) / 2;
                    int b = (t1.B + t2.B) / 2;
                    destinatie.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            pictureBox1.Image = destinatie;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = x; i < sursa.Width - x; i++)
            {
                for (int j = x; j < sursa.Height - x; j++)
                {
                    int r = 0, g = 0, b = 0;
                    for(int k = -x; k <= x; k++)
                    {
                        for(int l = -x; l <= x; l++)
                        {
                            Color T = sursa.GetPixel(i + k, j + l);
                            r += T.R;
                            g += T.G;
                            b += T.B;
                        }
                    }
                    Color New = Color.FromArgb(r / 25, g / 25, b / 25);
                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);

                    int nr, ng, nb;
                    nr = rnd.Next(Old.R);
                    ng = rnd.Next(Old.G);
                    nb = rnd.Next(Old.B);

                    Color New = Color.FromArgb(nr, ng, nb);

                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int k = 5;
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for(int i = 0; i < sursa.Width - k; i += k)
            {
                for(int j = 0; j < sursa.Height - k; j += k)
                {
                    for(int l = 0; l < k; l++)
                    {
                        for(int m = 0; m < k; m++)
                        {
                            destinatie.SetPixel(i + l, m + j, sursa.GetPixel(i, j));
                        }
                    }
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Old = sursa.GetPixel(i, j);
                    Color New;
                    int t = (Old.R + Old.G + Old.B) / 3;
                    if (t < 128)
                        New = Color.FromArgb(0, 0, 0);
                    else
                        New = Color.FromArgb(255, 0, 0);
                    
                    destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\scooby.jpg");
            pictureBox3.Image = sursa;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i+= 2)
            {
                for (int j = 0; j < sursa.Height; j+=2)
                {
                    Color Old = sursa.GetPixel(i, j);
                    int nr, ng, nb;
                    int t = (Old.R + Old.G + Old.B) / 3;
                    if (t < 128)
                        nr = 255;

                    //Color New = Color.FromArgb(nr, ng, nb);
                    //destinatie.SetPixel(i, j, New);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
