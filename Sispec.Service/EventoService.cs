using Sispec.Domain.Entities;
using Sispec.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Service
{
    public class EventoService : SispecService<Evento>
    {
        private SispecContext context;

        private Curso _curso;
        private Palestra _palestra;
        private Entreterimento _entreterimento;

        public EventoService()
        {

        }

        public Curso Curso()
        {


            using(context = new SispecContext())
            {
                _curso = new Curso();

            }
            

            return _curso;
        }

    }
}
