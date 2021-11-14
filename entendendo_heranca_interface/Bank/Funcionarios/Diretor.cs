using Bank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando um Diretor");
            
        }

        
        public override double GetBonificacao()
        {
            return Salario * 0.5 ;

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.15;
        }
    }
}
