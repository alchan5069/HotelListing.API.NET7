﻿using MyHotelListingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace MyHotelListingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<AuthResponseDto> Login(LoginDto userDto);

        Task<string> CreateRefreshToken();

        Task<AuthResponseDto> VerifyRefreshTokens(AuthResponseDto request);
    }
}
