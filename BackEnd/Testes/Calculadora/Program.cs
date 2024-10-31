using Calculadora.Services;

CalculadoraImp calculadora = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"Soma: {calculadora.Somar(num1, num2)}");
Console.WriteLine($"Subtração: {calculadora.Subtrair(num1, num2)}");
Console.WriteLine($"Multiplicação: {calculadora.Multiplicar(num1, num2)}");
Console.WriteLine($"Divisão: {calculadora.Dividir(num1, num2)}");