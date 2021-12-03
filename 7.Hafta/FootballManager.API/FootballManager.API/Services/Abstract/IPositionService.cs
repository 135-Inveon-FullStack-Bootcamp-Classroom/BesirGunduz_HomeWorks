using FootballManager.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Abstract
{
    public interface IPositionService
    {
        public Task<IEnumerable<Position>> GetAllAsync();
        public Task<Position> GetAsync(int id);
        public Task UpdateAsync(int id, Position position);
        public Task<Position> CreateAsync(Position position);
        public Task DeleteAsync(int id);
    }
}
