using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MyHotelListingAPI.Contracts;
using MyHotelListingAPI.Models.Users;
using MyHotelListingAPI.Data;

namespace MyHotelListingAPI.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;

            var results = await _userManager.CreateAsync(user, userDto.Password);

            if (results.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return results.Errors;
        }
    }
}
