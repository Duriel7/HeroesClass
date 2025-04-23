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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroDto>>> GetAllHeroes()
        {
            var heroes = await iService.GetAllHeroes();
            return Ok(heroes);
        }

        // GET: HeroController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetHero(int id)
        {
            var hero = await iService.GetHeroById(id);
            if (hero == null) return NotFound();
            return Ok(hero);
        }

        // GET: HeroController/Create
        [HttpPost]
        public async Task<ActionResult<List<Hero>>> CreateHero(Hero hero)
        {
            var heroes = await iService.AddHero(hero);
            return Ok(heroes);
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
