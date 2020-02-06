using Sispec.Domain.Entities;
using Sispec.Infra.Context;
using Sispec.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Service
{
    public class EntreterimentoService : SispecService<Entreterimento>
    {
        public Entreterimento EntreterimentoById(int id)
        {
            var _entreterimento = new Entreterimento();

            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Entreterimento>();
                _entreterimento = _repository.Select(id);
            }
            return _entreterimento;
        }
    }
}
