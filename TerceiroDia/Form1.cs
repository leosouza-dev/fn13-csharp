using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerceiroDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1 = 10;
            int nota2 = 8;
            int nota3 = 9;

            MessageBox.Show("Nota: " + nota1);
            MessageBox.Show("Nota: " + nota2);
            MessageBox.Show("Nota: " + nota3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nota1 = 10;
            int nota2 = 8;
            int nota3 = 9;

            int[] notas = new int[3];
            notas[0] = nota1;
            notas[1] = nota2;
            notas[2] = nota3;

            //nota1 = 5;

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    MessageBox.Show("Nota: " + notas[i]);
            //}

            foreach (var nota in notas)
            {
                MessageBox.Show("Notas: " + nota);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] empresas = new string[2];
            empresas[0] = "caelum";
            empresas[1] = "alura";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] empresas = new string[]
            {
                "caelum",
                "alura"
            };

            MessageBox.Show(empresas[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double[] salarios = { 1500.0, 2000.0, 10000.0 };
        }
    }
}
