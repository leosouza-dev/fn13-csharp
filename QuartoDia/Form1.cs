using QuartoDia.Contas;
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
    }
}
