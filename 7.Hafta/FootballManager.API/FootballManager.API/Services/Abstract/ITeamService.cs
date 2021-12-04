using FootballManager.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Abstract
{
    public interface ITeamService : IBaseService<Team>
    {
        public Task<IEnumerable<Team>> GetAllWithFootballersAsync();
    }
}
