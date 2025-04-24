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

        public async Task<List<HeroDto>> AddHero(Hero hero)
        {
            context.Heroes.Add(hero);
            await context.SaveChangesAsync();
            return await context.Heroes.Include(h => h.School)
                .Include(h => h.Powers)
                .Select(h => new HeroDto
                {
                    Id = h.Id,
                    Name = h.Name,
                    Description = h.Description,
                    Year = h.Year,
                    Rank = h.Rank,
                    School = h.School != null ? h.School.Name : null,
                    Powers = h.Powers.Select(p => p.Name).ToList()
                }).ToListAsync();
        }

        public async Task<List<SchoolDto>> AddSchool(School school)
        {
            context.Schools.Add(school);
            await context.SaveChangesAsync();
            return await context.Schools.Include(s => s.Heroes)
                .Select(s => new SchoolDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Rank = s.Rank,
                    Heroes = s.Heroes.Select(h => h.Name).ToList()
                }).ToListAsync();
        }

        public async Task<List<PowerDto>> AddPower(Power power)
        {
            context.Powers.Add(power);
            await context.SaveChangesAsync();
            return await context.Powers.Include(p => p.Owners)
                .Select(p => new PowerDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Rank = p.Rank,
                    Owners = p.Owners.Select(h => h.Name).ToList()
                }).ToListAsync();
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
                }).ToListAsync();
        }

        public async Task<List<SchoolDto>> GetAllSchools()
        {
            return await context.Schools
                .Include(h => h.Heroes)
                .Select(s => new SchoolDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Rank = s.Rank,
                    Heroes = s.Heroes.Select(h => h.Name).ToList()
                }).ToListAsync();
        }

        public async Task<List<PowerDto>> GetAllPowers()
        {
            return await context.Powers
                .Include(o => o.Owners)
                .Select(p => new PowerDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Rank =p.Rank,
                    Owners = p.Owners.Select(o => o.Name).ToList()
                }).ToListAsync();
        }

        public async Task<HeroDto> GetHeroById(int id)
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
                .FirstAsync(h => h.Id == id);
        }

        public async Task<SchoolDto> GetSchoolById(int id)
        {
            return await context.Schools
                .Select(s => new SchoolDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Rank = s.Rank,
                    Heroes = s.Heroes.Select(h => h.Name).ToList()
                })
                .FirstAsync(s => s.Id == id);
        }

        public async Task<PowerDto> GetPowerById(int id)
        {
            return await context.Powers
                .Select(p => new PowerDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Rank = p.Rank,
                    Owners = p.Owners.Select(o => o.Name).ToList()
                })
                .FirstAsync(p => p.Id == id);
        }
    }
}
