using ClasseAbstrata.Models;
using ClasseAbstrata.Interfaces;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

Computador comp = new Computador();
Console.WriteLine(comp.ToString());

Console.Clear();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 5));
Console.WriteLine(calc.Subtrair(10, 5));
Console.WriteLine(calc.Multiplicar(10, 5));
Console.WriteLine(calc.Dividir(10, 5));