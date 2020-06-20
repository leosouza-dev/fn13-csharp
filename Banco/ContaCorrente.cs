using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        public override void Despositar(double valorOperacao)
        {
            //base.Despositar(valorOperacao - 0.1);
            this.Saldo += valorOperacao - 0.1;
        }

        public override void Sacar(double valorOperacao)
        {
            this.Saldo -= valorOperacao + 0.05;
        }
    }
}
