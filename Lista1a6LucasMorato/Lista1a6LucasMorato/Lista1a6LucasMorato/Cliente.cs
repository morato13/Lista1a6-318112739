using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1a6LucasMorato
{
    class Cliente
    {

        private int saldo;
        private int conta;
        private int cobrancatotal;
        private int creditototal;
        private int limitecredito;


        public Cliente()

        {
            saldo = 0;
            conta = 0;
            cobranca_total = 0;
            credito_total = 0;
            limite_credito = 0;

        }



        public Cliente(int saldo, int conta, int cobrancatotal, int creditototal, int limitecredito)

        {
            this.saldo = saldo;
            this.conta = conta;
            this.cobrancatotal = cobrancatotal;
            this.creditototal = creditototal;
            this.limitecredito = limitecredito;

        }

        public int NovoSaldo()
        {
            return this.saldo + this.cobranca_total - this.credito_total;
        }

        public void AtualizaSaldo()
        {
            this.saldo = NovoSaldo();
        }

        public bool Limiteestourado()
        {
            return this.saldo > this.limite_credito;
        }

    }
}
