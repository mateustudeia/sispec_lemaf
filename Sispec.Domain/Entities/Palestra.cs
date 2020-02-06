using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Palestra : BaseEntity
    {
        public DateTime Data { get; set; }
        public DateTime tempoDuracao { get; set; }
        public int Palestrante { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual Evento Evento { get; set; }
    }
}
