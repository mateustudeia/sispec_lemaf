using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class PalestraModel : EventoModel
    {
        public DateTime Data { get; set; }
        public DateTime tempoDuracao { get; set; }
        public PessoaModel Palestrante { get; set; }

        public PalestraModel(Evento evento) : base(evento)
        {
            Data = evento.Palestra.Data;
            tempoDuracao = evento.Palestra.tempoDuracao;
            Palestrante = new PessoaModel(evento.Palestra.Pessoa);
        }
    }
}
