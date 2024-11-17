using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer las calificaciones desde los TextBox
            double C1 = double.Parse(textBox1.Text);
            double C2 = double.Parse(textBox2.Text);
            double C3 = double.Parse(textBox3.Text);
            double C4 = double.Parse(textBox4.Text);

            // Calcular el promedio
            double promedio = (C1 + C2 + C3 + C4) / 4;

            // Evaluar condiciones
            if (promedio >= 6 && C1 >= 6 && C2 >= 6 && C3 >= 6 && C4 >= 6)
            {
                lblResultado.Text = "Aprobado";
            }
            else
            {
                lblResultado.Text = "Reprobado";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
