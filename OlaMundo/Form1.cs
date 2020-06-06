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
    }
}
