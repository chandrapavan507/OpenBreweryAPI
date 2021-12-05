namespace OpenBreweryAPI.Models
{
    public class BreweryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website_url { get; set; }
        public string Street { get; set; }
        public string Address_2 { get; set; }
        public string Address_3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_code { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Brewery_type { get; set; }
    }
}
