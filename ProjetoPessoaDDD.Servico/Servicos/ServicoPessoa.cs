using ProjetoPessoaDDD.Dominio.Interface;
using ProjetoPessoaDDD.Dominio.Modelo;
using System;

namespace ProjetoPessoaDDD.Servico
{
    public class ServicoPessoa : IPessoa
    {
        public void Delete(string cpf)
        {
            //TODO: Inserir regra de Delete
        }

        public ModeloPessoa Insert(CriaModeloPessoa userModel)
        {
            //TODO: Criar regra de inserir
            return new ModeloPessoa("Mariana", 28, "12345678910");
        }

        public ModeloPessoa Update(string cpf, AlteraModeloPessoa userModel)
        {
            return new ModeloPessoa("Mariana Leite Dominguez", 28, "12345678910");
        }
    }
}