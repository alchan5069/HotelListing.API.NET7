using Microsoft.Build.Framework;

namespace MyHotelListingAPI.Models.Country
{
    public class CreateCountryDTO
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
