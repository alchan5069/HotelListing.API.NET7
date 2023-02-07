using MyHotelListingAPI.Data;

namespace MyHotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenerticRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
