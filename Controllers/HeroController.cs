using BNHA.Models.DTOs;
using BNHA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNHA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : Controller
    {

        private readonly IHeroService iService;

        public HeroController(IHeroService iHeroService)
        {
            iService = iHeroService;
        }


        // GET: HeroController
        [HttpGet("heroes")]
        public async Task<ActionResult<IEnumerable<HeroDto>>> GetAllHeroes()
        {
            var heroes = await iService.GetAllHeroes();
            return Ok(heroes);
        }

        [HttpGet("schools")]
        public async Task<ActionResult<IEnumerable<SchoolDto>>> GetAllSchools()
        {
            var schools = await iService.GetAllSchools();
            return Ok(schools);
        }

        [HttpGet("powers")]
        public async Task<ActionResult<IEnumerable<PowerDto>>> GetAllPowers()
        {
            var powers = await iService.GetAllPowers();
            return Ok(powers);
        }

        // GET: HeroController/Details/5
        [HttpGet("hero/{id}")]
        public async Task<ActionResult<Hero>> GetHero(int id)
        {
            var hero = await iService.GetHeroById(id);
            if (hero == null) return NotFound();
            return Ok(hero);
        }
        [HttpGet("school/{id}")]
        public async Task<ActionResult<School>> GetSchool(int id)
        {
            var school = await iService.GetSchoolById(id);
            if (school == null) return NotFound();
            return Ok(school);
        }
        [HttpGet("power/{id}")]
        public async Task<ActionResult<Power>> GetPower(int id)
        {
            var power = await iService.GetPowerById(id);
            if (power == null) return NotFound();
            return Ok(power);
        }

        // GET: HeroController/Create
        [HttpPost("hero")]
        public async Task<ActionResult<List<Hero>>> CreateHero(Hero hero)
        {
            var heroes = await iService.AddHero(hero);
            return Ok(heroes);
        }
        [HttpPost("school")]
        public async Task<ActionResult<List<School>>> CreateSchool(School school)
        {
            var schools = await iService.AddSchool(school);
            return Ok(schools);
        }
        [HttpPost("power")]
        public async Task<ActionResult<List<Power>>> CreatePower(Power power)
        {
            var powers = await iService.AddPower(power);
            return Ok(powers);
        }

        // POST: HeroController/Create
/*        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // GET: HeroController/Edit/5
/*        public ActionResult Edit(int id)
        {
            return View();
        }*/

        // POST: HeroController/Edit/5
/*        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // GET: HeroController/Delete/5
/*        public ActionResult Delete(int id)
        {
            return View();
        }*/

        // POST: HeroController/Delete/5
/*        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
