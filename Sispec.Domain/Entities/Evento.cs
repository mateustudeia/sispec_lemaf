using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Evento : BasePec
    { 
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Pessoa Organizador { get; set; }

    }
}
