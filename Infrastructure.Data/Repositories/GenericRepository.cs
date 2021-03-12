using Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext Context;

        public GenericRepository(DbContext context)
        {
            Context = context;
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }

    }
}
