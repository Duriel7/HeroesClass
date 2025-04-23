using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public interface IHeroService
    {
        Task<List<Hero>> GetAllHeroes();
    }
}
