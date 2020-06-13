using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private Conta conta1;
        private ContaPoupanca conta1;
        private RelatorioTotalizadorSaldo relatorio;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Maria");

            conta1 = new ContaPoupanca();
            conta1.Numero = 1;
            conta1.Titular = cliente1;

            //textoTitular.Text = cliente1.Nome;
            textoTitular.Text = conta1.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta1.Saldo);
            textoNumero.Text = Convert.ToString(conta1.Numero);


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            //recuperar o valor de operação
            string valorDigitado = textoValorOperacao.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            conta1.Despositar(valorOperacao);

            //ATUALIZAR O TEXTBOX
            textoSaldo.Text = Convert.ToString(conta1.Saldo);

            //opcinal
            relatorio = new RelatorioTotalizadorSaldo();
            relatorio.Totalizador(conta1);
            MessageBox.Show("Saldo do Banco: " + relatorio.ValorTotalSaldo);
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            var valorDigitado = textoValorOperacao.Text;

            double valorOperacao = Convert.ToDouble(valorDigitado);

            conta1.Sacar(valorOperacao);

            //ATUALIZAR O TEXTBOX
            textoSaldo.Text = Convert.ToString(conta1.Saldo);
        }
    }
}
