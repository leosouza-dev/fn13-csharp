using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class RelatorioTotalizadorSaldo
    {
        public double ValorTotalSaldo { get; set; }

        public void Totalizador(Conta conta)
        {
            ValorTotalSaldo += conta.Saldo;
        }
    }
}
