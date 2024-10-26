using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome}, tenho {Idade} anos. Sou aluno e minha nota é {Nota}.");
        }
    }
}