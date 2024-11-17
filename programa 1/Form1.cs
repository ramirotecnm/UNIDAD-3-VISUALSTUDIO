using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;  // Inicializamos la variable
            do
            {
                listBox1.Items.Add(i);  // Agregamos el número al ListBox
                i++;  // Incrementamos la variable
            }
            while (i <= 10);  // Condición para detener el ciclo cuando i sea mayor que 10

        }
    }
}
