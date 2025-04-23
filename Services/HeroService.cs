using BNHA.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public class HeroService : IHeroService
    {
        private readonly HeroContext context;

        public HeroService(HeroContext heroContext)
        {
            context = heroContext;
        }

        public async Task<List<Hero>> AddHero(Hero hero)
        {
            context.Heroes.Add(hero);
            await context.SaveChangesAsync();
            return await context.Heroes.Include(h => h.School).Include(h => h.Powers).ToListAsync();
        }

        public async Task<List<HeroDto>> GetAllHeroes()
        {
            return await context.Heroes
                .Include(h => h.School).Include(h => h.Powers)
                .Select(h => new HeroDto
                {
                    Id = h.Id,
                    Name = h.Name,
                    Description = h.Description,
                    Year = h.Year,
                    Rank = h.Rank,
                    School = h.School != null ? h.School.Name : null,
                    Powers = h.Powers.Select(p => p.Name).ToList()
                })
                .ToListAsync();
        }

        public async Task<Hero> GetHeroById(int id)
        {
            return await context.Heroes.Include(h => h.School).Include(h => h.Powers).FirstOrDefaultAsync(h => h.Id == id);
        }
    }
}
