using Sispec.Domain.Entities;
using Sispec.Domain.Models;
using Sispec.Infra.Context;
using Sispec.Infra.Repository;
using System;

namespace Sispec.Service
{
    public class CursoService : SispecService<Curso>
    {
        public Curso CursoById(int id)
        {
            var _curso = new Curso();

            using (var context = new SispecContext())
            {
                var _repository = new SispecRepository<Curso>();
                _curso = _repository.Select(id);
            }
            return _curso;
        }
    }
}