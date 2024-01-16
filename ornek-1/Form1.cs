﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        List<Bitmap> resimler = new List<Bitmap>();
        private void Form1_Load(object sender, EventArgs e)
        {
            resimler.Add(Properties.Resources.resim1);
            resimler.Add(Properties.Resources.resim2);
            resimler.Add(Properties.Resources.resim3);
            resimler.Add(Properties.Resources.resim4);
            resimler.Add(Properties.Resources.resim5);

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayac=sayac % resimler.Count;
            pictureBox1.Image=resimler[sayac];

           
        }
    }
}
