using MyHotelListingAPI.Data;
using MyHotelListingAPI.Models.Country;

namespace MyHotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenerticRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}