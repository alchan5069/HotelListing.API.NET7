using MyHotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Core.Models.Hotel
{
    public class UpdateHotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }
}