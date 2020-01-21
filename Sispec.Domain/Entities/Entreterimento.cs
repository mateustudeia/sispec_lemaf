using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Entreterimento : Evento
    { 
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Organizador { get; set; }

    }
}
