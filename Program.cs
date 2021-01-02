using ProjetoPessoaDDD.Dominio.Modelo;
using ProjetoPessoaDDD.Servico;
using System;

namespace ProjetoPessoaDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //oi
            ServicoPessoa servicoPessoa = new ServicoPessoa();

            servicoPessoa.Insert(new CriaModeloPessoa()
            {
                CPF = "12345678910",
                Nome = "Mariana",
                Idade = 28
            });

            servicoPessoa.Update("98765432199", new AlteraModeloPessoa()
            {
                Nome = "Mariana"
            });
        }
    }
}
