using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DBService
{
    public interface IRepo<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllFileName();
        Task<TEntity> GetByName(Expression<Func<TEntity, bool>> predicate);
        Task Update(TEntity entity);
    }
}
