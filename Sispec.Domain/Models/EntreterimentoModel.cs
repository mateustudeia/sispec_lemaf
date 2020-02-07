using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class EntreterimentoModel : EventoModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public PessoaModel Organizador { get; set; }

        public EntreterimentoModel(Evento evento) : base(evento)
        {
            DataInicio = evento.Entreterimento.DataInicio;
            DataFim = evento.Entreterimento.DataFim;
            Organizador = new PessoaModel(evento.Entreterimento.Organizador);
        } 
    }
}
