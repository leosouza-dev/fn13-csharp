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
    }
}
