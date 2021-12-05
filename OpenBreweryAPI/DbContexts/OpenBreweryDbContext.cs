using Microsoft.EntityFrameworkCore;
using OpenBreweryAPI.Entities;
using OpenBreweryAPI.Helpers;

namespace OpenBreweryAPI.DbContexts
{
    public class OpenBreweryDbContext : DbContext
    {
        public OpenBreweryDbContext(DbContextOptions<OpenBreweryDbContext> options)
        : base(options)
        {
        }
        public DbSet<Brewery> Brewerys { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<BreweryCategory> BreweryCategorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
