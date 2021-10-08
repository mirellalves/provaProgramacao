using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaLinguagemProgramacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char calculo = 'A';
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 'A';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 'S';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 'M';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 'D';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            numero1 = Double.Parse(textBox1.Text);
            numero2 = Double.Parse(textBox2.Text);

            if (calculo == 'A')
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
            }

            else if (calculo == 'S')
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }

            else if (calculo == 'M')
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }

            else
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString();
            }
        }
    }
}
