using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    public abstract
        class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public string Senha { get; set; }


        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando um funcionário");
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();


        public abstract void AumentarSalario();

       

    }
}
