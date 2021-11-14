using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando um novo Gerente de Conta "); 
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
