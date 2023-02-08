using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MyHotelListingAPI.Models.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}