using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void AddRange(IEnumerable<T> entities);
    }
}
