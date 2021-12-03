using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class TacticService : ITacticService
    {
        private readonly EfContext _context;

        public TacticService(EfContext context)
        {
            _context = context;
        }

        public Tactic Add(Tactic tactic)
        {
            _context.Tactics.Add(tactic);
            _context.SaveChanges();
            return tactic;

        }

        public Tactic Update(Tactic tactic)
        {
            _context.Tactics.Update(tactic);
            _context.SaveChanges();
            return tactic;
        }

        public void Delete(Tactic tactic)
        {
            _context.Tactics.Remove(tactic);
        }

        public async Task<IEnumerable<Tactic>> GetAllAsync()
        {
            return await _context.Tactics.ToListAsync();
        }

        public async Task<Tactic> GetAsync(int id)
        {
            var tactic = await _context.Tactics.FirstOrDefaultAsync(x => x.Id == id);
            return tactic;
        }
    }
}
