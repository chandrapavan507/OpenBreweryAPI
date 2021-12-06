using OpenBreweryAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Repositories
{
    public interface IBreweryRepository
    {
        Task<IEnumerable<Brewery>> GetBreweriesAsync(string city);
        Task<Brewery> GetBreweryAsync(int breweryId);
        Task<bool> SaveChangesAsync();
    }
}
