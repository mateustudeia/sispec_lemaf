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

        public virtual IList<InscritoEvento> Inscritos { get; set; }
        public virtual IList<Palestra> Palestra { get; set; }
        public virtual IList<Curso> Curso { get; set; }
        public virtual IList<Entreterimento> Entreterimento { get; set; }
               
    }
}
