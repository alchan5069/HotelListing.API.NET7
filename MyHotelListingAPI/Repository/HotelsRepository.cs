using AutoMapper;
using MyHotelListingAPI.Contracts;
using MyHotelListingAPI.Data;

namespace MyHotelListingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
