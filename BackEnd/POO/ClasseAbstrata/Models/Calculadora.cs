using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClasseAbstrata.Interfaces;

namespace ClasseAbstrata.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }
}