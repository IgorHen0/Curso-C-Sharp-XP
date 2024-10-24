int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

// Usando o FOR
Console.WriteLine("Usando o FOR:");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição {i} - Valor {arrayInteiros[i]}");
}

// Usando o FOREACH
Console.WriteLine("Usando o FOREACH:");
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Valor {valor}");
}

// Alterando o tamanho
Array.Resize(ref arrayInteiros, 5);

arrayInteiros[3] = 4;
arrayInteiros[4] = 5;

Console.WriteLine("Usando o FOREACH após o Resize:");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor {valor}");
}

// Copiando um array
int[] arrayCopia = new int[10];

Array.Copy(arrayInteiros, arrayCopia, arrayInteiros.Length);

Console.WriteLine("Usando o FOREACH após o Copy:");
foreach (int valor in arrayCopia)
{
    Console.WriteLine($"Valor {valor}");
}