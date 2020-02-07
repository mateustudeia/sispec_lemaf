using Sispec.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Entities
{
    public class Evento : BaseEntity
    {
        public virtual string Tema { get; set; }
        public virtual string Descricao { get; set; }
        public virtual int IdLocal { get; set; }
        public virtual IList<InscritoEvento> Inscritos { get; set; }
        public virtual int IdTipo { get; set; }

        public virtual Local Local { get; set; }
        public virtual TipoEvento TipoEvento { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Palestra Palestra { get; set; }
        public virtual Entreterimento Entreterimento { get; set; }

        public Evento()
        {

        }

        public Evento(EventoModel evento)
        {
            Tema = evento.Tema;
            Descricao = evento.Descricao;
            IdLocal = evento.Local.Id;
            IdTipo = evento.TipoEvento;
        }
    }
} 
