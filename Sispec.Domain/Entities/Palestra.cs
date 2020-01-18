using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Palestra : BaseEntity
    {
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public DateTime tempoDuracao { get; set; }
        public Local Local { get; set; }
        public Pessoa Palestrante { get; set; }
        public IList<Pessoa> Inscritos { get; set; }
    }
}
