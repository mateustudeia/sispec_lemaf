using Sispec.Domain.Entities;
using Sispec.Domain.Interfaces;
using Sispec.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sispec.Infra.Repository
{
    public class SispecRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private SispecContext context;

        public SispecRepository()
        {
            context = new SispecContext();
        }
        public void Insert(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);

        }

        public void Update(TEntity obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<TEntity>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<TEntity> Select()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity Select(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

    }
}
