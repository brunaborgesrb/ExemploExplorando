using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Bruna", "Borges");
Pessoa p2 = new Pessoa("Manuela", "Lira");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

