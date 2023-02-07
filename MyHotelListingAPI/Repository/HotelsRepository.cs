using MyHotelListingAPI.Contracts;
using MyHotelListingAPI.Data;

namespace MyHotelListingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
