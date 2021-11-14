using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar( string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criação de um novo auxiliar");
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
