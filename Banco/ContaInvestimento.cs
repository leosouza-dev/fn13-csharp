using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel 
    {
        public override void Despositar(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public override void Sacar(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }

        public double CalcularTributo()
        {
            return this.Saldo * 0.01;
        }
    }
}
