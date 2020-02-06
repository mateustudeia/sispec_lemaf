using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class PessoaModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public PessoaModel (Pessoa pessoa)
        {
            Nome = pessoa.Nome;
            Cpf = pessoa.Cpf;
            Contato = pessoa.Contato;
            Email = pessoa.Email;
            DataNascimento = pessoa.DataNascimento;
        }
    }
}
