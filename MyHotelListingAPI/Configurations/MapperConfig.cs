using AutoMapper;
using MyHotelListingAPI.Data;
using MyHotelListingAPI.Models.Country;
using MyHotelListingAPI.Models.Hotel;

namespace MyHotelListingAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
