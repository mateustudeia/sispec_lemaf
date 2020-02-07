using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class PalestraModel : EventoModel
    {
        public DateTime Data { get; set; }
        public string TempoDuracao { get; set; }
        public PessoaModel Palestrante { get; set; }

        public PalestraModel()
        {

        }

        public PalestraModel(Evento evento) : base(evento)
        {
            Data = evento.Palestra.Data;
            TempoDuracao = evento.Palestra.TempoDuracao;
            Palestrante = new PessoaModel(evento.Palestra.Palestrante);
        }

    }
}
