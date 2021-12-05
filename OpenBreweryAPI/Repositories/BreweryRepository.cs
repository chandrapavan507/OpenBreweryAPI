using Microsoft.EntityFrameworkCore;
using OpenBreweryAPI.DbContexts;
using OpenBreweryAPI.Entities;
using System;
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
        public async Task<IEnumerable<Brewery>> GetBreweriesAsync()
        {
            return await _openBreweryDbContext.Brewerys.
                Include(ad => ad.Address).
                Include(brt => brt.BreweryCategory).
                ToListAsync();               
        }

        public async Task<Brewery> GetBreweryAsync(int breweryId)
        {
            return await _openBreweryDbContext.Brewerys.
                Include(ad => ad.Address).
                Include(brt => brt.BreweryCategory).
                Where(b => b.BreweryId== breweryId).
                FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _openBreweryDbContext.SaveChangesAsync() > 0);
        }
    }
}
