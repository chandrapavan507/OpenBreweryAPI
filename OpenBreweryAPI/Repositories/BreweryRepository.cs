using Microsoft.EntityFrameworkCore;
using OpenBreweryAPI.DbContexts;
using OpenBreweryAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Repositories
{
    public class BreweryRepository : IBreweryRepository
    {
        private readonly OpenBreweryDbContext _openBreweryDbContext;
        public BreweryRepository(OpenBreweryDbContext openBreweryDbContext)
        {
            _openBreweryDbContext = openBreweryDbContext;
        }
        public async Task<IEnumerable<Brewery>> GetBreweriesAsync(string city)
        {
            var breweries = await _openBreweryDbContext.Brewerys.
               Include(ad => ad.Address).
               Include(brt => brt.BreweryCategory).
               ToListAsync();
            if (!string.IsNullOrEmpty(city))
            {
                return breweries.Where(c => c.Address.City == city);
            }
            return breweries;
        }

        public async Task<Brewery> GetBreweryAsync(int breweryId)
        {
            return await _openBreweryDbContext.Brewerys.
                Include(ad => ad.Address).
                Include(brt => brt.BreweryCategory).
                Where(b => b.BreweryId == breweryId).
                FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _openBreweryDbContext.SaveChangesAsync() > 0);
        }
    }
}
