using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // ALTERA A LOCALIZAÇÃO PADRÃO PARA EN-US
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// CONCATENAÇÃO STRING
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);

// CONCATENAÇÃO INT
int numero3 = 10;
int numero4 = 20;

int resultado2 = numero3 + numero4;

Console.WriteLine(resultado2);

// CONCATENAÇÃO STRING COM INT
string numero5 = "10";
int numero6 = 20;

string resultado3 = numero5 + numero6;

Console.WriteLine(resultado3);

Console.Clear();
// FORMATAÇÃO DE DECIMAL
Console.WriteLine("\nFORMATAÇÃO DE DECIMAIS");

decimal valorMonetario = 1082.40M;

Console.WriteLine($"O valor é: {valorMonetario:C}"); // VALOR EM REAL
Console.WriteLine("O valor é: " + valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // VALOR EM DÓLAR
Console.WriteLine("O valor é: " + valorMonetario.ToString("C1")); // UMA CASA DECIMAL
Console.WriteLine("O valor é: " + valorMonetario.ToString("C2")); // DUAS CASA DECIMAIS

// FORMATAÇÃO DE PORCENTAGEM
Console.WriteLine("\nFORMATAÇÃO DE PORCENTAGEM");
double porcentagem = .34214523;

Console.WriteLine($"A porcentagem é: {porcentagem:P2}"); // PORCENTAGEM COM DUAS CASAS DECIMAIS

// FORMATAÇÃO PERSONALIZADA
Console.WriteLine("\nFORMATAÇÃO PERSONALIZADA");
int numero = 123456789;

Console.WriteLine("O número é: " + numero.ToString("###-###-###"));

// FORMATAÇÃO DE DATA
Console.WriteLine("\nFORMATAÇÃO DE DATA");
DateTime data = DateTime.Now;

Console.WriteLine("A data é: " + data); // SEM FORMATAÇÃO
Console.WriteLine("A data é: " + data.ToString("dd/MM/yyyy HH:mm")); // SEM SEGUNDOS
Console.WriteLine("A data é: " + data.ToString("dd/MM/yyyy")); // APENAS DATA
Console.WriteLine("A data é: " + data.ToShortDateString()); // APENAS DATA
Console.WriteLine("A data é: " + data.ToShortTimeString()); // APENAS HORAS

// FORMATAÇÃO DE DATA COM TRY PARSE
Console.Clear();

string dataString = "2022-10-33 12:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

if (sucesso)
{
    Console.WriteLine("Data convertida: " + dataConvertida);
}
else
{
    Console.WriteLine("Data inválida");
}