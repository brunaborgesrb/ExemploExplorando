using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome) //construtor
        {
            Nome = nome;
            Sobrenome = sobrenome; 
        }

        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("o nome nao pode ser vazio");
                }

                _nome = value;
            }
            
        }

        public string Sobrenome
        { 
            get => _sobrenome.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("o sobrenome nao pode ser vazio");
                }

                _sobrenome = value;
            }
            
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("a idade nao pode ser menor que 0");
                }
                
                _idade = value;
            } 
            
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}