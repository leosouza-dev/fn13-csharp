using QuartoDia.Contas;
using QuartoDia.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NomeDaEmpresa.NomeDoProjeto.ModuloDoSistema

//Caelum.Banco.Contas

namespace QuartoDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta(Conta.RetornarProximoNumeroDaCOnta());
            MessageBox.Show("Numero da conta: " + c1.Numero);
            MessageBox.Show("Total de contas: " + Conta.TodalDeContasCriadas);

            Conta c2 = new Conta(Conta.RetornarProximoNumeroDaCOnta());
            MessageBox.Show("Numero da conta: " + c2.Numero);
            MessageBox.Show("Total de contas: " + Conta.TodalDeContasCriadas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta(5);
            c1.Saldo = 100;


            try
            {
                c1.Sacar(110);
                MessageBox.Show("Saque Realizado com Sucesso");
                MessageBox.Show("Saldo: " + c1.Saldo);
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Saldo: " + c1.Saldo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Saldo: " + c1.Saldo);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }



            //continua
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 2;

            if(a == b)
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta(1);
            Conta c2 = new Conta(1);

            if(c1.Equals(c2))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta c3 = new Conta(3);
            Conta c4 = new Conta(4);

            if(c3.Equals(c4))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Conta c5 = new Conta(5);
            c5.Titular = new Cliente();
            c5.Titular.Nome = "Maria";

            MessageBox.Show(c5.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Conta> contas = new List<Conta>();

            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            contas.Add(conta1);
            contas.Add(conta1);
            contas.Add(conta1);
            contas.Add(conta1);
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);

            foreach (var conta in contas)
            {
                MessageBox.Show("Numero: " + conta.Numero);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            List<Conta> contas = new List<Conta>()
            {
                conta1,
                conta2,
                conta3
            };

            contas.Add(new Conta(4));

            foreach (var conta in contas)
            {
                MessageBox.Show("Numero: " + conta.Numero);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            List<Conta> contas = new List<Conta>()
            {
                conta1,
                conta2,
                conta3
            };

            MessageBox.Show("Numero: " + contas[1].Numero);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            List<Conta> contas = new List<Conta>()
            {
                conta1,
                conta2,
                conta3
            };

            //contas.Remove(conta3);
            contas.RemoveAt(2);

            foreach (var conta in contas)
            {
                MessageBox.Show("Numero: " + conta.Numero);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            var conta4 = new Conta(4);

            List<Conta> contas = new List<Conta>()
            {
                conta1,
                conta2,
                conta3
            };

            if (contas.Contains(conta4))
            {
                MessageBox.Show("Contem");
            }
            else
            {
                MessageBox.Show("Não Contem");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var conta1 = new Conta(1);
            var conta2 = new Conta(2);
            var conta3 = new Conta(3);

            List<Conta> contas = new List<Conta>()
            {
                conta1,
                conta2,
                conta3
            };

            MessageBox.Show($"A lista possui {contas.Count} contas");
        }
    }
}
