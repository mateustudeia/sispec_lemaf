using Sispec.Domain.Entities;
using Sispec.Domain.Entities.Enums;
using Sispec.Domain.Models;
using Sispec.Infra.Context;
using Sispec.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sispec.Service
{
    public class EventoService : SispecService<Evento> 
    {
        private Evento _evento;
        public EventoService()
        {
        }

        public Evento EventoById(int id)
        {

            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Evento>();
                _evento = _repository.Select(id);

            }
            return _evento;
        }
        
        public void Inserir(Evento evento)
        {
            Post(evento);
            if (evento.IdTipo == (int)TipoEventoEnum.Palestra)
            {
                PalestraService palestra = new PalestraService();
                palestra.Post(evento.Palestra);
            } else if (evento.IdTipo == (int)TipoEventoEnum.Entreterimento)
            {
                EntreterimentoService entreterimento = new EntreterimentoService();
                entreterimento.Post(evento.Entreterimento);
            } else if(evento.IdTipo == (int)TipoEventoEnum.Curso)
            {
                CursoService curso = new CursoService();
                curso.Post(evento.Curso);
            }
        }

    }
}
