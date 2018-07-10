using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Interfaces
{
    public interface IRepository1<TEntity> where TEntity : Entity<TEntity>
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Remove(Guid id);
        int SaveChanges();
        void Update(TEntity obj);
    }
}