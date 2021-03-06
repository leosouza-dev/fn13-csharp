﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {

        public override void Despositar(double valorOperacao)
        {
            this.Saldo += valorOperacao - 0.08;
        }

        public override void Sacar(double valorOperacao)
        {
            this.Saldo -= valorOperacao + 0.1; //protected
        }

        public double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
