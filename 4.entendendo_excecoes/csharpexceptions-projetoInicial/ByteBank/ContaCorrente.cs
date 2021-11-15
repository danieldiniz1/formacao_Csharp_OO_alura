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

            

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor inválido para o saque", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }
    }
}
