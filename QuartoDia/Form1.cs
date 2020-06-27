using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
