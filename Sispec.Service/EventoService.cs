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
         
            _evento = new Evento(evento);
            Post(_evento);

                //var _palestraService = new PalestraService();
                //var _palestra = new Palestra(palestraModel);
                //_palestraService.Post(_palestra);                
        }

    }
}
