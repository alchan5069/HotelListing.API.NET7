using AutoMapper;
using MyHotelListingAPI.Data;
using MyHotelListingAPI.Models.Country;
using MyHotelListingAPI.Models.Hotel;

namespace MyHotelListingAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        }
    }
}
