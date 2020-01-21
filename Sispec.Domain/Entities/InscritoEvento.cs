using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class InscritoEvento
    {
        public int IdPessoa { get; set; }
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
