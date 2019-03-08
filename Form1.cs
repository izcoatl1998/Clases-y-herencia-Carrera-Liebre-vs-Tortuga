using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TortugavsLiebre
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
            liebre a = new liebre(1);
            tortuga b = new tortuga(2);

            do
            {
                textBox1.Text += "    LIEBRE: " + a.correr().ToString() + "\r\n" + "    TORTUGA: " + b.correr().ToString() + "\r\n";
            } while (a.posicion <= 99 && b.posicion <= 99);

            if (a.posicion >= 100)
                label1.Text = "el ganador es la liebre";
            else if (b.posicion >= 100)
                label1.Text = "el ganador es la tortuga";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
