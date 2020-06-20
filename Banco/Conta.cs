using System;

namespace Banco
{
    public abstract class Conta
    {
        //public Conta(int numero)
        //{
        //    Numero = numero;
        //}

        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public abstract void Despositar(double valorOperacao);

        public abstract void Sacar(double valorOperacao);
    }
}