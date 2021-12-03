using FootballManager.API.Data;
using FootballManager.API.Entities;
using FootballManager.API.Services.Abstract;
using FootballManager.API.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FootballManager.API.Services.Concrete
{
    public class CoachService : ICoachService
    {
        private readonly EfContext _context;

        public CoachService(EfContext context)
        {
            _context = context;
        }

        public Coach Add(Coach coach)
        {
            _context.Coaches.Add(coach);
            _context.SaveChanges();
            return coach;

        }

        public Coach Update(Coach coach)
        {
            _context.Coaches.Update(coach);
            _context.SaveChanges();
            return coach;
        }

        public void Delete(Coach coach)
        {
            _context.Coaches.Remove(coach);
        }

        public async Task<IEnumerable<Coach>> GetAllAsync()
        {
            return await _context.Coaches.ToListAsync();
        }

        public async Task<Coach> GetAsync(int id)
        {
            var coach = await _context.Coaches.FirstOrDefaultAsync(x => x.Id == id);
            return coach;
        }
    }
}
