using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
             Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados()
        {
            int quantidade = Alunos.Count; //retorna o numero de elementos dentro da lista
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
            
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                int exibicao = count + 1;
                string texto = $"N° {count + 1}  -  {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}