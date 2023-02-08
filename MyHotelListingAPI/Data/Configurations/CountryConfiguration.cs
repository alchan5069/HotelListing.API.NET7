using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyHotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Japan",
                    ShortName = "JP"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    ShortName = "CA"
                }
            );
        }
    }
}