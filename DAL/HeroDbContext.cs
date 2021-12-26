using hero_api.Models;
using Microsoft.EntityFrameworkCore;

namespace hero_api.DAL
{
    public class HeroDbContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
    }
}
