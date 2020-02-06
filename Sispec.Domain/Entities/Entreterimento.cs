using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Entreterimento : BaseEntity
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Organizador { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual Evento Evento { get; set; }
    }
}
