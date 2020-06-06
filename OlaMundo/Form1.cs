using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_OlaMundo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }

        private void Btn_PrimeiraConta_Click(object sender, EventArgs e)
        {
            // tipo + nomeDaVariavel
            string nome = "Caio";
            string sobrenome = "Silva";
            int numero = 1;
            double saldo = 100.0;
            double valorSaque = 10;

            // sacar 10
            //saldo = saldo - valorSaque;
            saldo -= valorSaque;

            MessageBox.Show("O nome do titular: " + nome + " " +  sobrenome);

            MessageBox.Show("O numero da conta: " + numero);
            MessageBox.Show("O saldo é : " + saldo);
        }

        private void btn_conv_Click(object sender, EventArgs e)
        {
            int valorInt = 100;

            short valorShort;
            long valorLong;

            //passar o int para long
            valorLong = valorInt;

            //passar o int para short - casting
            valorShort = (short)valorInt;

        }

        private void Btn_controle_Click(object sender, EventArgs e)
        {
            int numero = 1;
            double saldo = 100.0;
            double valorSaque = -10;

            // true ou false
            // > (maior), == (igual), <, <=
            // OU ||
            // And &&
            // !
            bool condicaoSaque = saldo >= valorSaque && valorSaque > 0;

            if (condicaoSaque)
            {
                saldo -= valorSaque; 
                MessageBox.Show("Saque realizado");
            }
            else
            {
                MessageBox.Show("Saque NÃO Realizado");
            }

            MessageBox.Show("" + saldo);


        }

        private void btn_repeticao_Click(object sender, EventArgs e)
        {
            // do while, for, while, foreach

            //while
            int i = 11; // inicialização

            do
            {
                MessageBox.Show("C# é melhor que Java");
            } while (i < 10);

            //while (i < 10) // condição
            //{
            //    MessageBox.Show("C# é melhor que Java");
            //    //i = i + 1;
            //    //i += 1;
            //    i++; // incremento
            //}

        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            // for
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("C# é melhor que Java");
            }

        }

        private void btn_rendimento_Click(object sender, EventArgs e)
        {
            // calculo de rendimento após 1 mês
            double valorInvestido = 1000.0;

            //calculo de rendimento
            //valorInvestido = valorInvestido + valorInvestido * 0.01;

            for (int i = 0; i < 12; i++)
            {
                valorInvestido += valorInvestido * 0.01;
            }

            MessageBox.Show("Valor Investido após um ano: " + valorInvestido.ToString("N2"));
            //teste
        }

        private void btn_multContas_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.titular = "Caio";
            c1.saldo = 1000.0;

            Conta c2 = new Conta();
            c2.saldo = 2;
            c2.titular = "Maria";
            c2.saldo = 1500.0;
        }

        private void btn_saqueProcedural_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.titular = "Caio";
            c1.saldo = 1000.0;

            if (c1.Sacar(100))
            {
                MessageBox.Show("Saque Realizado");
            }
            else
            {
                MessageBox.Show("Saque NÃO realizado");
            }


            MessageBox.Show("O Saldo é : " + c1.saldo);
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Depositar(10);

            MessageBox.Show("" + conta.saldo);
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            Conta contaCaio = new Conta();
            contaCaio.numero = 1;
            contaCaio.saldo = 1000;
            contaCaio.titular = "Caio";

            Conta contaMaria = new Conta();
            contaMaria.numero = 2;
            contaMaria.saldo = 1500;
            contaMaria.titular = "Maria";

            contaCaio.Transferir(5000, contaMaria);

            MessageBox.Show("Saldo Caio: " + contaCaio.saldo);
            MessageBox.Show("Saldo Maria: " + contaMaria.saldo);
        }
    }
}
