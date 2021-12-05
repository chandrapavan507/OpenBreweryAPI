using OpenBreweryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Repositories
{
    public interface IBreweryRepository
    {
        Task<IEnumerable<Brewery>> GetBreweriesAsync();
        Task<Brewery> GetBreweryAsync(int breweryId);
        Task<bool> SaveChangesAsync();
    }
}
