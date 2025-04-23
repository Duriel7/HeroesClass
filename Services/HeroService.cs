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

        Task<List<Hero>> IHeroService.GetAllHeroes()
        {
            throw new NotImplementedException();
        }
    }
}
