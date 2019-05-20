using System;
using System.Threading.Tasks;

namespace Core.DBService
{
    public interface IDbService : IDisposable
    {
        IRepo<TEntity> Repo<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}
