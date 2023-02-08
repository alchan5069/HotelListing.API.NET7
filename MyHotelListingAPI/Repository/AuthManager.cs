using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MyHotelListingAPI.Contracts;
using MyHotelListingAPI.Data;
using MyHotelListingAPI.Models.Users;

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

        public async Task<bool> Login(LoginDto loginDto)
        {
            bool isValidUser = false;
            try
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user is null)
                {
                    return default;
                }

                bool isValidCredentials = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                if (!isValidCredentials)
                {
                    return default;
                }
            }
            catch (Exception)
            {
                isValidUser = false;
            }

            return isValidUser;
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