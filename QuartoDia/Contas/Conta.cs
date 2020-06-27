using QuartoDia.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// QuartoDia.Contas
namespace QuartoDia
{
    namespace Contas
    {
        public class Conta
        {
            public Conta(int numero)
            {
                this.Numero = numero;
                Conta.TodalDeContasCriadas++;
            }

            //private static int _todalDeContasCriadas;
            public static int TodalDeContasCriadas { get; private set; }

            public Cliente Titular { get; set; }
            public int Numero { get; set; }
            public double Saldo { get; set; }

            // métodos
            public static int RetornarProximoNumeroDaCOnta()
            {
                return TodalDeContasCriadas + 1;
            }

            public void Sacar(double valor)
            {
                if(this.Saldo < valor)
                {
                    throw new SaldoInsuficienteException("Saldo Insuficiente");
                }
                if(valor < 0)
                {
                    throw new ArgumentException("Argumento Inválido");
                }

                this.Saldo -= valor;

            }
        }

    }
}
