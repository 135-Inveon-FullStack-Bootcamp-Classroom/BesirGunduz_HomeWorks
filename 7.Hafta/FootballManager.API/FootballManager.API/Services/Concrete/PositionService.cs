using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class PositionService : IPositionService
    {
        private readonly EfContext _context;

        public PositionService(EfContext context)
        {
            _context = context;
        }

        public Position Add(Position position)
        {
            _context.Positions.Add(position);
            _context.SaveChanges();
            return position;

        }

        public Position Update(Position position)
        {
            _context.Positions.Update(position);
            _context.SaveChanges();
            return position;
        }

        public void Delete(Position position)
        {
            _context.Positions.Remove(position);
        }

        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            return await _context.Positions.ToListAsync();
        }

        public async Task<Position> GetAsync(int id)
        {
            var position = await _context.Positions.FirstOrDefaultAsync(x => x.Id == id);
            return position;
        }
    }
}
