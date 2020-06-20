using System;

namespace Banco
{
    class Conta
    {
        //public Conta(int numero)
        //{
        //    Numero = numero;
        //}

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public virtual void Despositar(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Sacar(double valorOperacao)
        {
            Saldo -= valorOperacao;
        }
    }
}