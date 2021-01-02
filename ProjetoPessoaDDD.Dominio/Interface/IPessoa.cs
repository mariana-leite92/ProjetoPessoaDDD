using ProjetoPessoaDDD.Dominio.Modelo;
using System;

namespace ProjetoPessoaDDD.Dominio.Interface
{
    public interface IPessoa
    {
        ModeloPessoa Insert(CriaModeloPessoa userModel);

        ModeloPessoa Update(string cpf, AlteraModeloPessoa userModel);

        void Delete(string cpf);
    }
}
