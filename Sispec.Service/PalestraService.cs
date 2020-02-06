using Sispec.Domain.Entities;
using Sispec.Domain.Models;
using Sispec.Infra.Context;
using Sispec.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Service
{
    public class PalestraService : SispecService<Palestra>
    {
        public Palestra PalestraById(int id)
        {
            var _palestra = new Palestra();
            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Palestra>();
                _palestra = _repository.Select(id);
            }
            return _palestra;
        }
    }
}
