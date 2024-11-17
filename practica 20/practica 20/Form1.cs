using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            {
                // Leer la edad desde el TextBox
                int edad = int.Parse(textBoxEdad.Text);

                // Evaluar la categoría según la edad
                if (edad < 12)
                {
                    lblResultado.Text = "Es un Niño";
                }
                else if (edad < 18)
                {
                    lblResultado.Text = "Es un Adolescente";
                }
                else if (edad < 60)
                {
                    lblResultado.Text = "Es un Adulto";
                }
                else
                {
                    lblResultado.Text = "Es un Adulto Mayor";
                }
            }
        }
    }
}
