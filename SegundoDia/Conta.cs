using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoDia
{
    class Conta
    {
        public Conta()
        {

        }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
        }

        public Conta(int numero, double saldo)
        {
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public void Sacar(double valor)
        {
            if(this.Saldo >= (valor + 0.1))
            {
                this.Saldo -= (valor + 0.1);
            }
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}
