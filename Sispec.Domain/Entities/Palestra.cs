using Sispec.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Palestra : BaseEntity
    {
        public DateTime Data { get; set; }
        public string TempoDuracao { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Palestrante { get; set; }

        public virtual Evento Evento { get; set; }


        public Palestra()
        {
        }
        public Palestra(PalestraModel palestra)
        {
            Data = palestra.Data;
            TempoDuracao = palestra.TempoDuracao;
            IdPessoa = palestra.Palestrante.Id;
        }
    }
}
