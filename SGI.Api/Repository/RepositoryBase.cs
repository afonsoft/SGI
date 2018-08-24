using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SGI.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SGI.Api.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        public DbContext context;
        public DbSet<TEntity> dbSet;
        internal IEntityType _entityType;
        internal IEnumerable<IProperty> _properties;
        internal IModel _model;
        public string primaryKeyName;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();

            _model = this.context.Model;
             _entityType = _model.FindEntityType(typeof(TEntity));
             _properties = _entityType.GetProperties();
            primaryKeyName = _entityType.FindPrimaryKey().Properties.First().Name;

        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public TEntity GetById(long id)
        {
            return (dbSet.FirstOrDefault(e => (long)e.GetType().GetProperty(primaryKeyName).GetValue(e) == id));
        }

        public void DeleteById(long id)
        {
            TEntity entity = GetById(id);
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            //pegar o valor da pk do objeto
            var entry = context.Entry<TEntity>(entity);
            var pkey = entity.GetType().GetProperty(primaryKeyName).GetValue(entity);
            
            if (entry.State == EntityState.Detached)
            {
                var set = context.Set<TEntity>();
                TEntity attachedEntity = set.Find(pkey);  // access the key 
                if (attachedEntity != null)
                {
                    var attachedEntry = context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified; // attach the entity 
                }
            }

            context.SaveChanges();
        }

        public void UpdateById(TEntity entity, long id)
        {
            var set = context.Set<TEntity>();
            TEntity attachedEntity = GetById(id);  // access the key 
            if (attachedEntity != null)
            {
                var attachedEntry = context.Entry(attachedEntity);
                attachedEntry.CurrentValues.SetValues(entity);
                context.SaveChanges();
            }
        }

        /// <summary> 
        /// Método que deleta um objeto no banco de dados da aplicação. 
        /// </summary> 
        public void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary> 
        /// Método que deleta um ou varios objetos no banco de dados da aplicação, mediante uma expressão LINQ. 
        /// </summary> 
        public void DeleteAll(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = dbSet;
            List<TEntity> listDelete = query.Where(filter).ToList();

            foreach (var item in listDelete)
            {
                dbSet.Remove(item);
            }
            context.SaveChanges();
        }

        /// <summary> 
        /// Método que adiciona uma lista de novos objetos ao banco de dados da aplicação. 
        /// </summary> 
        public void AddAll(List<TEntity> entity)
        {
            foreach (var item in entity)
            {
                dbSet.Add(item);
            }
            context.SaveChanges();
        }

        /// <summary> 
        /// Método que busca uma lista de objetos no banco de dados da aplicação e retorna-a no tipo IEnumerable<TEntity>. 
        /// </summary> 
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public void Dispose()
        {
            dbSet = null;
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }
    }
}
