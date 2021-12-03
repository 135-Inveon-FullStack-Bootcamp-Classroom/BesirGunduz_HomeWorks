using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Abstract
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int id);
        TEntity Add(TEntity coach);
        TEntity Update(TEntity coach);
        void Delete(TEntity coach);
    }
}
