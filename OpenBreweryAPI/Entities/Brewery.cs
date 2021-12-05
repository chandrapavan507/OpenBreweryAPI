using System;
using System.ComponentModel.DataAnnotations;

namespace OpenBreweryAPI.Entities
{
    public class Brewery
    {
        public int BreweryId { get; set; }
        public string Name { get; set; }
        public int BreweryCategoryId { get; set; }       
        public int AddressId { get; set; }
        [Required]
        public string WebSiteURL { get; set; }
        public Address Address { get; set; }
        public BreweryCategory BreweryCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Phone { get; set; }
    }
}
