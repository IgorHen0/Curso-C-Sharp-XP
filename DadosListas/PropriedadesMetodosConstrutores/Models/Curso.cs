using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Curso
    {
        private string _nome = string.Empty;

        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome do curso não pode ser vazio");
                }

                _nome = value;
            }
        }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public int ObterNumeroAlunos()
        {
            return Alunos.Count;
        }
    }
}