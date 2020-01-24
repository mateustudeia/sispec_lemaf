using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Service
{
    public class EventoService : SispecService<Evento>
    {
        private Curso _curso;
        private Palestra _palestra;
        private Entreterimento _entreterimento;

        public EventoService(int id)
        {

        }

        public Curso CriarEventoCurso()
        {

            _curso = new Curso();

            return _curso;
        }

    }
}
