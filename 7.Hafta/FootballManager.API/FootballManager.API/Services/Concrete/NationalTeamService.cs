using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class NationalTeamService : INationalTeamService
    {
        private readonly EfContext _context;

        public NationalTeamService(EfContext context)
        {
            _context = context;
        }

        public NationalTeam Add(NationalTeam nationalTeam)
        {
            _context.NationalTeams.Add(nationalTeam);
            _context.SaveChanges();
            return nationalTeam;

        }

        public NationalTeam Update(NationalTeam nationalTeam)
        {
            _context.NationalTeams.Update(nationalTeam);
            _context.SaveChanges();
            return nationalTeam;
        }

        public void Delete(NationalTeam nationalTeam)
        {
            _context.NationalTeams.Remove(nationalTeam);
        }

        public async Task<IEnumerable<NationalTeam>> GetAllAsync()
        {
            return await _context.NationalTeams.ToListAsync();
        }

        public async Task<NationalTeam> GetAsync(int id)
        {
            var nationalTeam = await _context.NationalTeams.FirstOrDefaultAsync(x => x.Id == id);
            return nationalTeam;
        }
    }
}
