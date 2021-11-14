using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer( string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criação de um novo Designer");
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }

}
