using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Cliente cliente1 = new Cliente();
            //cliente1.nome = "Maria";
            //cliente1.cpf = "12345678912";
            //cliente1.rg = "1213456789";
            //cliente1.endereco = "Av Paulista, 1200";

            //Conta contaMaria = new Conta();
            //contaMaria.titular = cliente1;
            //contaMaria.numero = 1;
            //contaMaria.saldo = 1500;

            //MessageBox.Show("Nome do cliente da conta: " + contaMaria.titular.nome);
            //MessageBox.Show("Nome do cliente da conta: " + cliente1.nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conta conta1 = new Conta();
            //conta1.numero = 1;
            //conta1.saldo = 1500;

            //conta1.titular = new Cliente();
            //conta1.titular.nome = "Caio";
            //conta1.titular.rg = "123";
            //conta1.titular.cpf = "123";
            //conta1.titular.endereco = "rua x";

            //MessageBox.Show("Nome do titular: " + conta1.titular.nome);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Numero = 1;
            c1.Depositar(1500);
            MessageBox.Show("Saldo: " + c1.Saldo);
            MessageBox.Show("Numero: " + c1.Numero);
            //c1.SetNumero(1);
            //MessageBox.Show("Numero: " + c1.GetNumero());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // numero e saldo
            //Conta c2 = new Conta(2, 1500);

            //Conta c4 = new Conta(500.0);

            //Conta c3 = new Conta();
            //c3.Numero = 3;
            //c3.Titular = new Cliente();

            //Initializer
            //Conta c5 = new Conta()
            //{
            //    Numero = 5,
            //    Titular = new Cliente()
            //};
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente("Maria");

            Cliente c2 = new Cliente();
        }
    }
}
