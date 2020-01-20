using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post(T obj) ;

        T Put(T obj) ;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();

    }
}
