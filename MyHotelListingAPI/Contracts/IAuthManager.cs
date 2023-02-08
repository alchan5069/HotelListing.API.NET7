using MyHotelListingAPI.Models.Users;

namespace MyHotelListingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<bool> Register(ApiUserDto userDto);
    }
}
