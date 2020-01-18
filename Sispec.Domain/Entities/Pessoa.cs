using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
