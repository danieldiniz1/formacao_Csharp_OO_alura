using Bank.Funcionarios;
using Bank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.156.156-80") { Nome = "Roberta", Senha = "123" };
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "ABC");

            GerenteDeConta camila = new GerenteDeConta("125.654.985-80") { Nome = "Camila", Senha = "456" };
            sistemaInterno.Logar(camila, "456");

            ParceiroComercial parceiro = new ParceiroComercial() {Senha = "789" };
            sistemaInterno.Logar(parceiro, "789");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("987.658.789-80") { Nome = "Pedro" };

            Diretor roberta = new Diretor("985.465.987-90") { Nome = "Roberta" };

            Auxiliar igor = new Auxiliar("654.564.115-89") { Nome = "Igor" };

            GerenteDeConta camila = new GerenteDeConta("123.456.789-80") { Nome = "Camila" };

            Desenvolvedor guilherme = new Desenvolvedor("123.644.698-80") { Nome = "Guilherme" };

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine($"O valor total pago de bonificação será de {gerenciadorBonificacao.GetTotalBonificacao()}");

        }
    }
}
