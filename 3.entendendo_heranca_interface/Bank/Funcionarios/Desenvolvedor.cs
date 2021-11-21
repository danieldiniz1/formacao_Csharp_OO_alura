using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(7000, cpf)
        {
            Console.WriteLine("Criação de um novo Desenvolvedor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.18;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.19;
        }
    }
}
