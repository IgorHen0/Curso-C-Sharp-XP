using ExcecoesColecoes.Models;

// TRY, CATCH E FINALLY
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // OK
    // string[] linhas = File.ReadAllLines("Arquivos/texto/arquivo_Leitura.txt"); // DIRECTORY NOT FOUND
    // string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt"); // FILE NOT FOUND
    
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine("Arquivo não encontrado: " + e.Message);
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine("Diretório não encontrado: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
}
finally
{
    Console.WriteLine("Terminou de tratar as exceções, caso haja alguma.");
}

// THROW
new ExemploExcecao().Metodo1(); // Ocorreu uma exceção!

Console.Clear();

// COLEÇÕES - FILA/QUEUE
Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o item: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.Clear();

// COLEÇÕES - PILHA/STACK
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(8);
pilha.Push(12);
pilha.Push(16);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o item: {pilha.Pop()}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.Clear();

// COLEÇÕES - DICIONÁRIO
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG", "Minas Gerais");
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("ES", "Espirito Santo");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine($"\nRemovendo o item: {estados.Remove("SP")}"); // RETORNA BOOL

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine();
estados["RJ"] = "RJ NÃO DEVIA EXISTIR";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// BUSCANDO UMA CHAVE
string chave = "SP";
Console.WriteLine($"\nBuscando: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Estado presente no dicionário");
} else
{
    Console.WriteLine("Estado não encontrado no dicionário");
}