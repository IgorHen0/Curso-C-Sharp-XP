using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome}, tenho {Idade} anos. Sou professor e meu salário é {Salario:C}.");
        }
    }
}