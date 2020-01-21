using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Palestra : Evento
    {
        public DateTime Data { get; set; }
        public DateTime tempoDuracao { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Palestrante { get; set; }
        
    }
}
