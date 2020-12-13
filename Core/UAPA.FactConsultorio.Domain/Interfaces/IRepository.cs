using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    public interface IRepository<T> where T: EntityBase
    {
        T GetById(int id);
        ICollection<T> GetAll();
        ICollection<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        void Add(T entity);
        void Update(T entity, int userId);
        bool Exists(int id);
        void Delete(int id, int userId);//Update enabled=false
        void Remove(int id);//Remove from BD
    }
}