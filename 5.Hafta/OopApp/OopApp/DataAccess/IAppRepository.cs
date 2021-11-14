using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OopApp.DataAccess
{
    public interface IAppRepository<TEntity>
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
