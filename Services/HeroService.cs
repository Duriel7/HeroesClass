using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public class HeroService
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
            return await context.Heroes.ToListAsync();
        }
    }
}
