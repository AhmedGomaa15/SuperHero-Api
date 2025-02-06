using Microsoft.EntityFrameworkCore;
using SuperHero_Api.Entities;

namespace SuperHero_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
