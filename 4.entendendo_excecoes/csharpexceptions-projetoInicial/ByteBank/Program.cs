using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH no Método Main");
            }
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt"))
            {
                leitor.LerProximaLinha();
            }



            // -----------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contasl.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //catch (IOException)
            //{

            //    Console.WriteLine("Exceção do tipo IOException Capturada e tratada");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}

        }



        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 123653);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argumento com problema: {ex.ParamName}");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);

                Console.WriteLine(ex.StackTrace);

                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
