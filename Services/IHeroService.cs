using BNHA.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BNHA.Services
{
    public interface IHeroService
    {
        Task<List<HeroDto>> GetAllHeroes();
        Task<List<HeroDto>> AddHero(Hero hero);
        Task<HeroDto> GetHeroById(int id);
        Task<List<SchoolDto>> GetAllSchools();
        Task<List<SchoolDto>> AddSchool(School school);
        Task<SchoolDto> GetSchoolById(int id);
        Task<List<PowerDto>> GetAllPowers();
        Task<List<PowerDto>> AddPower(Power power);
        Task<PowerDto> GetPowerById(int id);
    }
}
