using TuplaOperadorTernarioDesconstrucao.Models;

Console.Clear();

(int, string, string) tupla = (0, "Igor", "Henrique");
ValueTuple<int, string, string> outraTupla = (1, "Guilherme", "Arana");
var tuplaCreate = Tuple.Create(2, "Jorge", "Aragão");

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Tupla: {tupla}");
Console.WriteLine();
Console.WriteLine($"ID: {outraTupla.Item1}");
Console.WriteLine($"Nome: {outraTupla.Item2}");
Console.WriteLine($"Sobrenome: {outraTupla.Item3}");
Console.WriteLine($"Tupla: {outraTupla}");
Console.WriteLine();
Console.WriteLine($"ID: {tuplaCreate.Item1}");
Console.WriteLine($"Nome: {tuplaCreate.Item2}");
Console.WriteLine($"Sobrenome: {tuplaCreate.Item3}");
Console.WriteLine($"Tupla: {tuplaCreate}");

Console.Clear();

LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, LinhasArquvio, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // "_" => DESCARTAR INFORMAÇÕES DA TUPLA

if(Sucesso)
{
    foreach(string linhas in LinhasArquvio)
    {
        // Console.WriteLine($"Quantidade de linhas: {QuantidadeLinhas}");
        Console.WriteLine(linhas);
    }
}
else
{
    Console.WriteLine("Não foi possível ver o arquivo.");
}

Console.Clear();

// IF TERNÁRIO
int numero = 20;

string resultado = (numero % 2 == 0) ? "O número é par" : "O número é ímpar";
Console.WriteLine(resultado);