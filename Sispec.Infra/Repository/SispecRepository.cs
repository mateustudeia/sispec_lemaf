using Sispec.Domain.Entities;
using Sispec.Domain.Interfaces;
using Sispec.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sispec.Infra.Repository
{
    public class SispecRepository<T> : IRepository<T> where T : BaseEntity
    {

        public void Insert(T obj)
        {
            using (var context = new SispecContext())
            {
                context.Set<T>().Add(obj);
            }
        }

        public void Update(T obj)
        {
            using (var context = new SispecContext())
            {
                context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (var context = new SispecContext())
            {
                context.Set<T>().Remove(Select(id));
                context.SaveChanges();
            }
        }

        public IList<T> Select()
        {
            using (var context = new SispecContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T Select(int id)
        {
            using (var context = new SispecContext())
            {
                return context.Set<T>().Find(id);
            }
        }

    }
}
