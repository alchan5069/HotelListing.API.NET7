using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using MyHotelListingAPI.Controllers;
using MyHotelListingAPI.Data;
using MyHotelListingAPI.Repository;

namespace HotelListingAPI.Test.Controllers
{
    public class HotelControllerTest : DisposableTestBase
    {
        private HotelsController _hotelController;

        //private Mock<IHotelsRepository> _repository;
        private HotelsRepository _hotelRepository;

        private Mock<IMapper> _mapper;
        private HotelListingDbContext _context;

        [SetUp]
        public void Setup()
        {
            // _repository = new Mock<IHotelsRepository>();
            _context = new InMemoryDbContextFactory().GetHotelDbContext();
            _mapper = new Mock<IMapper>();
            _hotelRepository = new HotelsRepository(_context, _mapper.Object);
            // _hotelController = new HotelsController(_repository.Object, _mapper.Object);
        }

        /// <summary>
        /// Sample test.
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_GetAsync_HotelController_Should_Return_200Ok()
        {
            // arrange
            var hotel = new Hotel
            {
                Id = 1,
                Name = "Test",
                Address = "123 Country",
                CountryId = 1,
                Rating = 5
            };

            // act

            // Save a record to the database, then try and read it back
            // _context.Hotels.AddAsync(hotel); // context probably needs some mocking of records to have it working?
            var addResult = _hotelRepository.AddAsync(hotel);
            // _context.SaveChangesAsync();

            var result = _hotelRepository.GetAsync(hotel.Id);

            // assert

            result.Should().NotBeNull();
            result.Result.Name.Should().Be("Test");

            //Assert.Pass();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _hotelController.Dispose();
            }
        }
    }

    internal class InMemoryDbContextFactory
    {
        public HotelListingDbContext GetHotelDbContext()
        {
            var options = new DbContextOptionsBuilder<HotelListingDbContext>()
                            .UseInMemoryDatabase(databaseName: "InMemoryArticleDatabase")
                            .Options;
            var dbContext = new HotelListingDbContext(options);

            return dbContext;
        }
    }
}