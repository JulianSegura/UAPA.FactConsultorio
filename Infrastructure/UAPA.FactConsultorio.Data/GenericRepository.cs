using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using UAPA.FactConsultorio.Domain;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Data
{
    public class GenericRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbSet<T> _dbSet;
        private static DateTime currentTime = DateTime.UtcNow;

        public GenericRepository(DbContext context)
        {
            _dbSet = context.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public ICollection<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query).ToList() : query.ToList();

        }

        public virtual void Add(T entity, int userId)
        {

            if (entity is AuditableEntityBase e)
            {
                e.DateCreated = currentTime;
                e.UpdatedBy = userId;
            }

            _dbSet.Add(entity);
        }

        public virtual void Update(T entity, int userId)
        {
            if (entity is AuditableEntityBase e)
            {
                e.UpdatedBy = userId;
            }
            _dbSet.Update(entity);
        }

        public virtual bool Exists(int id)
        {
            return _dbSet.Any(c => c.Id == id);
        }

        public virtual void Delete(int id, int userId)
        {
            var entity = GetById(id);

            entity.Enabled = false;

            if (entity is AuditableEntityBase e)
            {
                e.UpdatedBy = userId;
            }

            _dbSet.Update(entity);
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            _dbSet.Remove(entity);
        }
    }
}
