using Sispec.Domain.Entities;
using Sispec.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Models
{
    public class EventoModel 
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public LocalModel Local { get; set; }
        public int TipoEvento { get; set; }

        public CursoModel Curso { get; set; }
        public PalestraModel Palestra { get; set; }
        public EntreterimentoModel Entreterimento { get; set; }
        //public InscritoEventoModel Inscritos { get; set; }

        public EventoModel(IList<Evento> list)
        {

        }
        public EventoModel(Evento evento)
        {
            Id = evento.Id;
            Tema = evento.Tema;
            Descricao = evento.Descricao;
            Local = new LocalModel(evento.Local);
            TipoEvento = evento.IdTipo;
            if ((evento.IdTipo == (int)TipoEventoEnum.Palestra))
            {
                Palestra = new PalestraModel(evento.Palestra);
            }
            else if(evento.IdTipo == (int)TipoEventoEnum.Curso)
            {
                Curso = new CursoModel(evento.Curso);
            }
            else if (evento.IdTipo == (int)TipoEventoEnum.Entreterimento)
            {
                Entreterimento = new EntreterimentoModel(evento.Entreterimento);
            }
        }
    }
}
