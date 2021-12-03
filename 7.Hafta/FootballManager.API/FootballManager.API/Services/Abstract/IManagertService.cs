using FootballManager.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Abstract
{
    public interface IManagertService
    {
        public Task<IEnumerable<Manager>> GetAllAsync();
        public Task<Manager> GetAsync(int id);
        public Task UpdateAsync(int id, Manager manager);
        public Task<Manager> CreateAsync(Manager manager);
        public Task DeleteAsync(int id);
    }
}
