using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                listBox1.Iteam.Add(x);
                x++;
            }
            while (x <= 10);
        }
    }
}
