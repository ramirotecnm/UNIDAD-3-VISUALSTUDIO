﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, nsue;
            sueldo = double.Parse(textBox1.Text);

            if (sueldo < 400000) nsue = sueldo * 1.15;
            else nsue = sueldo * 1.08;
            textBox2.Text = nsue.ToString();

        }
    }
}
