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
        private int _numeroDeContas;

        private void Form1_Load(object sender, EventArgs e)
        {
            // criando array de conta
            this.contas = new Conta[100];

            ContaInvestimento c1 = new ContaInvestimento();
            c1.Titular = new Cliente("Maria");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            ContaPoupanca c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Caio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            ContaCorrente c3 = new ContaCorrente();
            c3.Titular = new Cliente("José");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            //this.contas[0] = new Conta();
            //this.contas[0].Numero = 1;
            //this.contas[0].Titular = new Cliente("Maria");

            //this.contas[1] = new ContaCorrente();
            //this.contas[1].Numero = 2;
            //this.contas[1].Titular = new Cliente("Caio");

            //this.contas[2] = new ContaPoupanca();
            //this.contas[2].Numero = 3;
            //this.contas[2].Titular = new Cliente("José");

            //foreach (var conta in contas)
            //{
            //    comboContas.Items.Add("titular: " + conta.Titular.Nome);
            //}

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

        public void AdicionaConta(Conta conta)
        {
            // add a conta no array
            this.contas[this._numeroDeContas] = conta;

            // atualiza o numero de contas
            this._numeroDeContas++;

            // add a conta no comboBox
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        private void BtnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void BtnTributo_Click(object sender, EventArgs e)
        {
            var sv = new SeguroDeVida();

            var ci = new ContaInvestimento();
            ci.Despositar(1000);

            var cp = new ContaPoupanca();
            cp.Despositar(2000);

            var t = new TotalizadorDeTributos();
            t.Acumular(sv);
            MessageBox.Show("Tributo: " + t.Total);

            t.Acumular(ci);
            MessageBox.Show("Tributo: " + t.Total);

            t.Acumular(cp);
            MessageBox.Show("Tributo: " + t.Total);
        }
    }
}
