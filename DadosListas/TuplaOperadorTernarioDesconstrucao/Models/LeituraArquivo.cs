using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace TuplaOperadorTernarioDesconstrucao.Models
{
    public class LeituraArquivo
    {

        public LeituraArquivo()
        {
            Caminho = string.Empty;
        }

        public LeituraArquivo(string caminho)
        {
            Caminho = caminho;
        }

        public void Deconstruct(out string caminho)
        {
            caminho = Caminho;
        }

        public string Caminho { get; set; }

        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}