using System;
using System.Collections.Generic;
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
                ContaCorrente conta = new ContaCorrente(0123, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argumento com problema: {ex.ParamName}");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.ReadLine();
        }
    }
}
