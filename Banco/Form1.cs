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

        private Conta[] contas;

        private void Form1_Load(object sender, EventArgs e)
        {
            // criando array de conta
            this.contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Numero = 1;
            this.contas[0].Titular = new Cliente("Maria");

            this.contas[1] = new ContaCorrente();
            this.contas[1].Numero = 2;
            this.contas[1].Titular = new Cliente("Caio");

            this.contas[2] = new ContaPoupanca();
            this.contas[2].Numero = 3;
            this.contas[2].Titular = new Cliente("José");

            foreach (var conta in contas)
            {
                comboContas.Items.Add("titular: " + conta.Titular.Nome);
            }

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // encontrando o indice
            int indice = comboContas.SelectedIndex;

            // encontra a conta desejada
            Conta contaSelecionada = contas[indice];

            // exibe os dados
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            // encontra o indice
            int indice = comboContas.SelectedIndex;

            // encontra a conta
            Conta selecionada = this.contas[indice];

            // encontra o valor digitado
            double valor = Convert.ToDouble(textoValorOperacao.Text);

            // deposita
            selecionada.Despositar(valor);

            // atualiza saldo
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            // encontra o indice
            int indice = comboContas.SelectedIndex;

            // encontra a conta
            Conta selecionada = this.contas[indice];

            // encontra o valor digitado
            double valor = Convert.ToDouble(textoValorOperacao.Text);

            // deposita
            selecionada.Sacar(valor);

            // atualiza saldo
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

    }
}
