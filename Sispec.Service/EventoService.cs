using Sispec.Domain.Entities;
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
        private Curso _curso;
        private Palestra _palestra;
        private Entreterimento _entreterimento;
        //private SispecRepository<Evento> _repository;

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

        public Curso CursoById(int id)
        {
            
            using(var context = new SispecContext())
            {
                var _repository = new SispecRepository<Curso>();
                _curso = _repository.Select(id);
            }
            return _curso;
        }

        public Entreterimento EntreterimentoById(int id)
        {

            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Entreterimento>();
                _entreterimento = _repository.Select(id);
            }
            return _entreterimento;
        }

        public Palestra PalestraById(int id)
        {

            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Palestra>();
                _palestra = _repository.Select(id);
            }
            return _palestra;
        }

        public void Inserir(Evento evento)
        {
            
            if (evento.IdTipo == 1)
            {
                PalestraService palestra = new PalestraService();
                palestra.Post(evento.Palestra);
            } else if (evento.IdTipo == 2)
            {
                EntreterimentoService entreterimento = new EntreterimentoService();
                entreterimento.Post(evento.Entreterimento);
            } else
            {
                CursoService curso = new CursoService();
                curso.Post(evento.Curso);
            }
        }

    }
}
