using SGI.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SGI.Api.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddAll(List<TEntity> entity);
        IEnumerable<TEntity> Get();
        TEntity GetById(long id);
        void Delete(TEntity entity);
        void DeleteById(long id);
        void DeleteAll(Expression<Func<TEntity, bool>> filter = null);
        void Update(TEntity entity);
        void UpdateById(TEntity entity, long id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);
    }
}
