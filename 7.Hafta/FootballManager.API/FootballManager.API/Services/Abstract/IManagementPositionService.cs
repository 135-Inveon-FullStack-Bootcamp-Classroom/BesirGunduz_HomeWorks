using FootballManager.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Abstract
{
    public interface IManagementPositionService
    {
        public Task<IEnumerable<ManagementPosition>> GetAllAsync();
        public Task<Footballer> GetAsync(int id);
        public Task UpdateAsync(int id, ManagementPosition managementPosition);
        public Task<ManagementPosition> CreateAsync(ManagementPosition managementPosition);
        public Task DeleteAsync(int id);
    }
}
