using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Entities
{
    public class BreweryCategory
    {
        public int BreweryCategoryId { get; set; }
        public string Type { get; set; }
        public Collection<Brewery> Brewerys { get; set; }
    }
}
