using NugetSerializarAtributos.Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

DateTime dataAtual = DateTime.Now;

Venda venda1 = new Venda(1, "Caneta", 1.99m, dataAtual);
Venda venda2 = new Venda(2, "Lápis", 0.99m, dataAtual);
Venda venda3 = new Venda(3, "Borracha", 0.50m, dataAtual);
Venda venda4 = new Venda(4, "Apontador", 1.50m, dataAtual);

listaVendas.Add(venda1);
listaVendas.Add(venda2);
listaVendas.Add(venda3);
listaVendas.Add(venda4);

// string serializado = JsonConvert.SerializeObject(new Venda[] { venda1, venda2, venda3, venda4 }, Formatting.Indented);
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);