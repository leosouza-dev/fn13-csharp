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

        private void button5_Click(object sender, EventArgs e)
        {
            List<Conta> contas = new List<Conta>
            {
                new Conta("Caio"),
                new Conta("Leonardo"),
                new Conta("José"),
                new Conta("Antonio"),
                new Conta("Darci"),
            };

            string titularDaBusca = "Darci";
            Conta contaEsperada = null;

            foreach (var conta in contas)
            {
                if (conta.Titular.Equals(titularDaBusca))
                {
                    contaEsperada = conta;
                    break;
                }
            }

            MessageBox.Show("Resultado: " + contaEsperada.Titular);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta("Maria");
            var conta2 = new Conta("José");
            var conta3 = new Conta("Pedro");

            //Dictinary<key, Value>
            Dictionary<string, Conta> dicionarioDeConta = new Dictionary<string, Conta>();
            dicionarioDeConta.Add(conta1.Titular, conta1);
            dicionarioDeConta.Add(conta2.Titular, conta2);
            dicionarioDeConta.Add(conta3.Titular, conta3);


            Conta contaEsperada = dicionarioDeConta["Pedro"];
            MessageBox.Show("Resultado: " + contaEsperada.Titular);

            foreach (var conta in dicionarioDeConta)
            {
                MessageBox.Show("A chave é: " + conta.Key);
                MessageBox.Show("O valor é: " + conta.Value);
            }
        }
    }
}
