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
    public partial class FormCadastroConta : Form
    {
        private Form1 _formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this._formPrincipal = formPrincipal;

            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            //adicionaCOnta
            this._formPrincipal.AdicionaConta(novaConta);

            //fechar
            this.Close();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }

    }
}
