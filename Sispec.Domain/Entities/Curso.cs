using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Curso : BaseEntity 
    {
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime TempoDuracao { get; set; }
        public Local Local { get; set; }
        public string PreRequisitos { get; set; }
        public string FerramentasUtilizadas { get; set; }
        public Pessoa Orientador { get; set; }
        public IList<Pessoa> Inscritos { get; set; }
    }
}
