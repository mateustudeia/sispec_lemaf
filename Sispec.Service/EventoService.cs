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
        
        public void Inserir(EventoModel evento)
        {
            if (evento.TipoEvento == (int)TipoEventoEnum.Palestra)
            {
                 var palestraModel = (PalestraModel)evento;

                _evento = new Evento(palestraModel);
                Post(_evento);

                var _palestraService = new PalestraService();
                var _palestra = new Palestra(palestraModel);
                _palestraService.Post(_palestra);                
            }
            else if (evento.TipoEvento == (int)TipoEventoEnum.Entreterimento)
            {
                var entreterimentoModel = (EntreterimentoModel)evento;
                _evento = new Evento(entreterimentoModel);
                Post(_evento);

                var _entreterimentoService = new EntreterimentoService();
                var _entreterimento = new Entreterimento(entreterimentoModel);
                _entreterimentoService.Post(_entreterimento);

            } else if(evento.TipoEvento == (int)TipoEventoEnum.Curso)
            {
                var cursoModel = (CursoModel)evento;
                _evento = new Evento(cursoModel);
                Post(_evento);

                var _cursoService = new CursoService();
                var _curso = new Curso(cursoModel);
                _cursoService.Post(_curso);
            }
        }

    }
}
