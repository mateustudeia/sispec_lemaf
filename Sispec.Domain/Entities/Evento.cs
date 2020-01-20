using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Evento : BasePalestraEventoCurso
    { 
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Pessoa Organizador { get; set; }

    }
}
