// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }



        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int NumeroAgencia, int NumeroConta)
        {
            
            if (NumeroAgencia <= 0)
            {
                ArgumentException excecao = new ArgumentException("Agencia deve ser maior que 0.", nameof(NumeroAgencia));
                throw excecao;
            }
            if (NumeroConta <= 0)
            {
                ArgumentException excecao = new ArgumentException("Conta deve ser maior que 0",nameof(NumeroConta));
                throw excecao;
            }
            Agencia = NumeroAgencia;
            Numero = NumeroConta;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {

            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
