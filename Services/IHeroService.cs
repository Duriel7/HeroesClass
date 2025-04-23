using BNHA.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public interface IHeroService
    {
        Task<List<HeroDto>> GetAllHeroes();
        Task<List<HeroDto>> AddHero(Hero hero);
        Task<HeroDto> GetHeroById(int id);
        Task<List<HeroDto>> GetAllSchools();
        Task<List<HeroDto>> AddSchool(School school);
        Task<HeroDto> GetSchoolById(int id);
        Task<List<HeroDto>> GetAllPowers();
        Task<List<HeroDto>> AddPower(Power power);
        Task<HeroDto> GetPowerById(int id);
    }
}
