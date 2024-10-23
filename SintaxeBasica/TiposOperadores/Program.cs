// Cast de inteiros

using System.Reflection.Metadata;

int a = Convert.ToInt32("10");
Console.WriteLine(a);

int b = int.Parse("100");
Console.WriteLine(b);

int c = Convert.ToInt32(null);
Console.WriteLine(c);

string texto = "100e0";
int reserva = 0;

int.TryParse(texto, out reserva);
Console.WriteLine(reserva);

// Erro
// int d = int.Parse(null);
// Console.WriteLine(d);

// Cast de string para int

string e = Convert.ToString(10);
Console.WriteLine(e);

int inteiro = 5;
string f = inteiro.ToString();
Console.WriteLine(f);


// Operadores Condicionais
Console.Clear();

int quantidadeEmEstoque = 10;
int quantidadeDesejada = 5;

if (quantidadeDesejada <= quantidadeEmEstoque)
{
    if (quantidadeDesejada == 0)
    {
        Console.WriteLine("Pedido inválido");
    }
    else
    {
        Console.WriteLine("Pedido realizado com sucesso");
    }
}
else
{
    Console.WriteLine("Quantidade insuficiente em estoque");
}


// Switch
Console.Clear();

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine() ?? string.Empty;

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra digitada é uam vogal");
        break;
    default:
        Console.WriteLine("A letra digitada é uma consoante");
        break;
}

// Operadores lógicos
Console.Clear();

bool ehMaiorDeIdade = true;
bool possuiAutorizacao = false;

if (ehMaiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Pode entrar");
}
else
{
    Console.WriteLine("Não pode entrar");
}

Console.WriteLine();

bool possuiPresenca = true;
double media = 7.5;

if (possuiPresenca && media >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

Console.WriteLine();

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou ao cinema");
}
else
{
    Console.WriteLine("Não vou ao cinema");
}