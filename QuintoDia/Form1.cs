using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuintoDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> clientes = new List<string>();

            List<string> devedores = new List<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            var devedor1 = devedores[0];

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            if (devedores.Contains("Jose"))
            {
                MessageBox.Show("Cliente Devedor");
            }
            else
            {
                clientes.Add("Jose");
                MessageBox.Show("Cliente Adicionado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> clientes = new List<string>();

            HashSet<string> devedores = new HashSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            if (devedores.Contains("Gabriela"))
            {
                MessageBox.Show("Cliente Devedor");
            }
            else
            {
                clientes.Add("Gabriela");
                MessageBox.Show("Cliente Adicionado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet<string> devedores = new HashSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");

            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }

            MessageBox.Show("Numero de devedores: " + devedores.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortedSet<string> devedores = new SortedSet<string>();
            devedores.Add("Leonardo");
            devedores.Add("Caio");
            devedores.Add("Lucas");
            devedores.Add("Larissa");
            devedores.Add("Leonardo");
            devedores.Add("Gabriela");
            devedores.Add("Alan");


            foreach (var item in devedores)
            {
                MessageBox.Show(item);
            }
        }
    }
}
