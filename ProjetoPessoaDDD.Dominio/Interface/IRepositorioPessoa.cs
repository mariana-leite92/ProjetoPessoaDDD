using ProjetoPessoaDDD.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPessoaDDD.Dominio.Interface
{
    public interface IRepositorioPessoa
    {
        List< ModeloPessoa> RetornaTodasPessoas();
        ModeloPessoa RetornaPessoaPorCPF(string cpf);    
    }
}
