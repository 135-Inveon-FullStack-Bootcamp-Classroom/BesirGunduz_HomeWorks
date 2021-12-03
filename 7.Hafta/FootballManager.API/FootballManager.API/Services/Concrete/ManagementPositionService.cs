using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class ManagementPositionService : IManagementPositionService
    {
        private readonly EfContext _context;

        public ManagementPositionService(EfContext context)
        {
            _context = context;
        }

        public ManagementPosition Add(ManagementPosition managementPosition)
        {
            _context.ManagementPositions.Add(managementPosition);
            _context.SaveChanges();
            return managementPosition;

        }

        public ManagementPosition Update(ManagementPosition managementPosition)
        {
            _context.ManagementPositions.Update(managementPosition);
            _context.SaveChanges();
            return managementPosition;
        }

        public void Delete(ManagementPosition managementPosition)
        {
            _context.ManagementPositions.Remove(managementPosition);
        }

        public async Task<IEnumerable<ManagementPosition>> GetAllAsync()
        {
            return await _context.ManagementPositions.ToListAsync();
        }

        public async Task<ManagementPosition> GetAsync(int id)
        {
            var managementPosition = await _context.ManagementPositions.FirstOrDefaultAsync(x => x.Id == id);
            return managementPosition;
        }
    }
}
