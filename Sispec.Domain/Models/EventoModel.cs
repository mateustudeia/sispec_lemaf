using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public abstract class EventoModel 
    {
        public virtual int Id { get; set; }
        public virtual string Tema { get; set; }
        public virtual string Descricao { get; set; }
        public virtual LocalModel Local { get; set; }


        public EventoModel()
        {

        }
        public EventoModel(Evento evento)
        {
            Id = evento.Id;
            Tema = evento.Tema;
            Descricao = evento.Descricao;
            Local = new LocalModel(evento.Local);
        }
    }
}
