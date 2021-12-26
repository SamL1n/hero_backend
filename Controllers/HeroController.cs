using hero_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hero_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Hero> GetHero(int id)
        {
            var hero = this.heroes.FirstOrDefault(h=> h.Id == id);
            if (hero == null) return NotFound();
            else return hero;
        }

        [HttpGet]
        public ActionResult<Hero[]> GetAllHeroes()
        {
            return this.heroes;
        }

        private Hero[] heroes = {
            new Hero { Id = 1, Name = "John", Age = 12, Country = "USA" },
            new Hero { Id = 2, Name = "Sam", Age = 13, Country = "China" },
            new Hero { Id = 3, Name = "DouDou", Age = 14, Country = "Ice Island" },
            new Hero { Id = 4, Name = "Riven", Age = 15, Country = "England" },
            new Hero { Id = 5, Name = "Bat Man", Age = 16, Country = "German" },
            new Hero { Id = 6, Name = "Spider Man", Age = 17, Country = "Japan" }
        };
    }
}
