using ProjetoPessoaDDD.Dominio.Interface;
using ProjetoPessoaDDD.Dominio.Modelo;
using System;
using System.Collections.Generic;

namespace ProjetoPessoaDDD.Repositorio
{

    public class RepositorioPessoa : IRepositorioPessoa
    {
        public ModeloPessoa RetornaPessoaPorCPF(string cpf)
        {
            return new ModeloPessoa("Mariana", 28, "12345678910");
        }

        public List<ModeloPessoa> RetornaTodasPessoas()
        {
            return new List<ModeloPessoa>();
        }
    }
}