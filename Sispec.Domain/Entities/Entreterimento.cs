using Sispec.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Entreterimento : BaseEntity
    {
        
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Organizador{ get; set; }

        public virtual Evento Evento { get; set; }

        public Entreterimento()
        {

        }
        public Entreterimento(EntreterimentoModel entreterimento)
        {
            DataInicio = entreterimento.DataInicio;
            DataFim = entreterimento.DataFim;
            IdPessoa = entreterimento.Organizador.Id;
        }
    }
}
