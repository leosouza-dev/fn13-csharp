using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoDia
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

        public string Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        // métodos
        public static int RetornarProximoNumeroDaCOnta()
        {
            return TodalDeContasCriadas + 1;
        }
    }
}
