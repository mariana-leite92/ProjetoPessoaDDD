using System;

namespace ProjetoPessoaDDD.Dominio.Modelo
{
    public class ModeloPessoa
    {
        public ModeloPessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
} 
