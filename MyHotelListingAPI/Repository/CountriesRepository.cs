﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyHotelListingAPI.Contracts;
using MyHotelListingAPI.Data;

namespace MyHotelListingAPI.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;
        public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        Task ICountriesRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
