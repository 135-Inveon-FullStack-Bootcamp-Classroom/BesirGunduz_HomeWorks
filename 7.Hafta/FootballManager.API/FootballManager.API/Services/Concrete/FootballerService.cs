using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class FootballerService : IFootballerService
    {
        private readonly EfContext _context;

        public FootballerService(EfContext context)
        {
            _context = context;
        }

        public Footballer Add(Footballer footballer)
        {
            _context.Footballers.Add(footballer);
            _context.SaveChanges();
            return footballer;

        }

        public Footballer Update(Footballer footballer)
        {
            _context.Footballers.Update(footballer);
            _context.SaveChanges();
            return footballer;
        }

        public void Delete(Footballer footballer)
        {
            _context.Footballers.Remove(footballer);
        }

        public async Task<IEnumerable<Footballer>> GetAllAsync()
        {
            return await _context.Footballers.ToListAsync();
        }

        public async Task<Footballer> GetAsync(int id)
        {
            var footballer = await _context.Footballers.FirstOrDefaultAsync(x => x.Id == id);
            return footballer;
        }
    }
}
