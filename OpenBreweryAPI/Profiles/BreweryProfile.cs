using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Profiles
{
    public class BreweryProfile:Profile
    {
        public BreweryProfile()
        {
            CreateMap<Models.BreweryDto, Entities.Brewery>()
             .ForPath(bentity => bentity.Address.Latitude, dto => dto.MapFrom(src => src.Latitude))
             .ForPath(bentity => bentity.Address.Longitude, dto => dto.MapFrom(src => src.Longitude))
             .ForPath(bentity => bentity.Address.Address2, dto => dto.MapFrom(src => src.Address_2))
             .ForPath(bentity => bentity.Address.Address3, dto => dto.MapFrom(src => src.Address_3))
             .ForPath(bentity => bentity.Address.City, dto => dto.MapFrom(src => src.City))
             .ForPath(bentity => bentity.Address.Street, dto => dto.MapFrom(src => src.Street))
             .ForPath(bentity => bentity.Address.ZipCode, dto => dto.MapFrom(src => src.Postal_code))
             .ForPath(bentity => bentity.Address.State, dto => dto.MapFrom(src => src.State))
             .ForPath(bentity => bentity.BreweryCategory.Type, dto => dto.MapFrom(src => src.Brewery_type))
             .ForPath(bentity => bentity.BreweryId, dto => dto.MapFrom(src => src.Id))
             .ForPath(bentity => bentity.WebSiteURL, dto => dto.MapFrom(src => src.Website_url))
            .ReverseMap();
        }
        

    }
}
