// FOR
Console.WriteLine("FOR");
int numero = 5;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.Clear();

// WHILE
Console.WriteLine("WHILE");

int contador = 0;

while(contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}

Console.Clear();

// BREAK
Console.WriteLine("BREAK");

for (int i = 0; i <= 10; i++)
{
    if(i == 5)
    {
        break;
    }

    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.Clear();

// DO WHILE
Console.WriteLine("DO WHILE");

int soma = 0;
int num = 0;

do
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    soma += num;
    Console.WriteLine($"Soma: {soma}");
} while (num != 0);