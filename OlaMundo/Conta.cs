using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    // um tipo
    // new
    class Conta
    {
        // atributos
        public int numero;
        public string titular;
        public double saldo;

        public bool Sacar(double valor) //500
        {
            if(this.saldo >= valor && valor > 0)
            {
                this.saldo -= valor;
                return true;
            }
           
            return false;   
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            //this.saldo -= valorTransferencia;
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.saldo += valorTransferencia;
            }
        }
    }
}
