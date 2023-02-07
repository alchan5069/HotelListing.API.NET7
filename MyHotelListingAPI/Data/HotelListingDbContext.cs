using Microsoft.EntityFrameworkCore;

namespace MyHotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {}

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id= 1,
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

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Napon",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Canada Resort and Spa",
                    Address = "Calgary",
                    CountryId = 2,
                    Rating = 5.0
                }
             );
        }
    }
}
