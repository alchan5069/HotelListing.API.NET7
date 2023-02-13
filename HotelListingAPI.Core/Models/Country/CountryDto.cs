using MyHotelListingAPI.Models.Hotel;

namespace MyHotelListingAPI.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }

        public List<HotelDto>? Hotels { get; set; }
    }
}
