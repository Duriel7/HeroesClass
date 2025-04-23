using BNHA.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public interface IHeroService
    {
        Task<List<HeroDto>> GetAllHeroes();
        Task<List<Hero>> AddHero(Hero hero);
        Task<Hero> GetHeroById(int id);
    }
}
