using Microsoft.EntityFrameworkCore;
using OpenBreweryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Helpers
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   AddressId = 1,
                   Street = "400 Brown Cir",
                   Address2 = "",
                   Address3 = "",
                   City = "Knox",
                   State = "Indiana",
                   ZipCode = "46534",
                   Latitude = 41.289715,
                   Longitude = -86.627954
               },
               new Address
               {
                   AddressId = 2,
                   Street = "62950 NE 18th St",
                   Address2 = "",
                   Address3 = "",
                   City = "Bend",
                   State = "Oregon",
                   ZipCode = "97701-9847",
                   Latitude = 44.0912109,
                   Longitude = - 121.2809536
               },
               new Address
               {
                   AddressId = 3,
                   Street = "826 W Bannock St",
                   Address2 = "",
                   Address3 = "",
                   City = "Boise",
                   State = "Idaho",
                   ZipCode = "83702-5857",
                   Latitude = 43.618516,
                   Longitude = -116.202929
               });

            modelBuilder.Entity<BreweryCategory>().HasData(
                new BreweryCategory
                {
                    BreweryCategoryId =1,
                    Type="medium"
                },
                new BreweryCategory
                {
                    BreweryCategoryId = 2,
                    Type = "micro"
                },
                new BreweryCategory
                {
                    BreweryCategoryId = 3,
                    Type = "large"
                }
                );
            modelBuilder.Entity<Brewery>().HasData(
                
                new Brewery 
                {
                    BreweryId=1,
                    Name = "10-barrel-brewing-co-bend-1",
                    BreweryCategoryId =1,
                    AddressId=1,
                    WebSiteURL= "http://www.10barrel.com",
                    CreatedAt =DateTime.UtcNow,
                    Phone= "5415851007"
                },
                new Brewery 
                {
                    BreweryId = 2,
                    Name = "10 Torr Distilling and Brewing",
                    BreweryCategoryId = 2,
                    AddressId = 2,
                    WebSiteURL = "http://www.10barrel.com",
                    CreatedAt = DateTime.UtcNow,
                    Phone = "5415851007"
                },
                new Brewery 
                {
                    BreweryId = 3,
                    Name = "10 Barrel Brewing Co - Bend Pub",
                    BreweryCategoryId = 3,
                    AddressId = 3,
                    WebSiteURL = "http://www.10barrel.com",
                    CreatedAt = DateTime.UtcNow,
                    Phone = "5415851007"
                });
        }
    }
}
