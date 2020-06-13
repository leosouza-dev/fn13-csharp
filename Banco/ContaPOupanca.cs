using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero) : base(numero)
        {
        }

        public override void Sacar(double valorOperacao)
        {
            base.Sacar(valorOperacao + 0.1);
            //this.Saldo -= valorOperacao + 0.1; //protected
        }
    }
}
