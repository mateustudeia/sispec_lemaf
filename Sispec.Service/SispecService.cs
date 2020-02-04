using Sispec.Domain.Entities;
using Sispec.Domain.Interfaces;
using Sispec.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Service
{
    public class SispecService<T> : IService<T> where T : BaseEntity
    {
        private SispecRepository<T> repository = new SispecRepository<T>();
        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");
            repository.Remove(id);
        }

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");
            return repository.Select(id);
        }

        public IList<T> Get() => repository.Select();

        public T Post(T obj)
        {
            repository.Insert(obj);
            return obj;
        }

        public T Put(T obj)
        {
            repository.Update(obj);
            return obj;
        }
    }
}
