using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class ManagerService : IManagerService
    {
        private readonly EfContext _context;

        public ManagerService(EfContext context)
        {
            _context = context;
        }

        public Manager Add(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
            return manager;

        }

        public Manager Update(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }

        public void Delete(Manager manager)
        {
            _context.Managers.Remove(manager);
        }

        public async Task<IEnumerable<Manager>> GetAllAsync()
        {
            return await _context.Managers.ToListAsync();
        }

        public async Task<Manager> GetAsync(int id)
        {
            var manager = await _context.Managers.FirstOrDefaultAsync(x => x.Id == id);
            return manager;
        }
    }
}
