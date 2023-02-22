using Bogus;
using MyHotelListingAPI.Data;

namespace HotelListingAPI.Test.Fakes

{
    public sealed class HotelFaker : Faker<Hotel>
    {
        public HotelFaker()
        {
            var f = new Faker();
            var size = 30;
            var str = f.Random.Chars(count: size);

            RuleFor(hotel => hotel.Id, f => f.Random.Number());
            RuleFor(hotel => hotel.Name, f => f.Lorem.Word());
            RuleFor(hotel => hotel.Address, f => f.Lorem.Sentence());
            RuleFor(hotel => hotel.Rating, f => f.Random.Number(5));
            RuleFor(hotel => hotel.CountryId, f => f.Random.Number(5));
            RuleFor(hotel => hotel.Country, _ => new Country
            {
                Id = 1,
                Name = f.Lorem.Word(),
                ShortName =  f.Lorem.Letter()
            });
        }
    }
}