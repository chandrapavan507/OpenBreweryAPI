using System.Collections.ObjectModel;

namespace OpenBreweryAPI.Entities
{
    public class BreweryCategory
    {
        public int BreweryCategoryId { get; set; }
        public string Type { get; set; }
        public Collection<Brewery> Brewerys { get; set; }
    }
}
