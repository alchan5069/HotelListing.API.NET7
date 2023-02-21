using AutoMapper;
using HotelListingAPI.Core.Models.Hotel;
using MyHotelListingAPI.Data;
using MyHotelListingAPI.Models.Country;
using MyHotelListingAPI.Models.Hotel;
using MyHotelListingAPI.Models.Users;

namespace MyHotelListingAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, UpdateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
