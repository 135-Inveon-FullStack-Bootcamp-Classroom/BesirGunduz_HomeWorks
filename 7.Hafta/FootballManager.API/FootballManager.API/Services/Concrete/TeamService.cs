using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class TeamService : ITeamService
    {
        private readonly EfContext _context;

        public TeamService(EfContext context)
        {
            _context = context;
        }

        public Team Add(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return team;

        }

        public Team Update(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
            return team;
        }

        public void Delete(Team team)
        {
            _context.Teams.Remove(team);
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetAsync(int id)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
            return team;
        }

        public async Task<IEnumerable<Team>> GetAllWithFootballersAsync()
        {
            return await _context.Teams.Include(p => p.Footballers).ToListAsync();
        }
    }
}
