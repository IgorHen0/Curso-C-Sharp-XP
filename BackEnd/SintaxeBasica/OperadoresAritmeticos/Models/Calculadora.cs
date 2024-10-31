using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperadoresAritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} + {y} é igual a {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} - {y} é igual a {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} * {y} é igual a {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} / {y} é igual a {x / y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"A potência de {x} ^ {y} é igual a {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"O seno de {angulo} é igual a {Math.Sin(radiano):F4}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"O cosseno de {angulo} é igual a {Math.Cos(radiano):F4}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"A tangente de {angulo} é igual a {Math.Tan(radiano):F4}");
        }

        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"A raiz quadrada de {x} é igual a {Math.Sqrt(x):F4}");
        }
    }
}