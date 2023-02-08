using MyHotelListingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace MyHotelListingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<bool> Login(LoginDto userDto);
    }
}
