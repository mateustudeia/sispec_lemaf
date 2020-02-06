using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class InscritoEvento : BaseEntity
    {
        public int IdPessoa { get; set; }
        public int IdEvento { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
