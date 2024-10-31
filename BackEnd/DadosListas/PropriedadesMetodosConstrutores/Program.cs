using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Igor";
p1.Sobrenome = "Henrique";
p1.Idade = 21;

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Sobrenome = "Silva";
p2.Idade = 20;

Pessoa p3 = new Pessoa("Maria", "Santos");
p3.Idade = 25;

Curso curso = new Curso();
curso.Nome = "Programação C#";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.ListarAlunos();

int numeroAlunos = curso.ObterNumeroAlunos();
Console.WriteLine($"Quantidade de alunos: {numeroAlunos}");