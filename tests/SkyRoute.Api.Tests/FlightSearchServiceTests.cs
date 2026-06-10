using System.Threading;
using System.Threading.Tasks;
using SkyRoute.Api.Models;
using SkyRoute.Api.Services;
using Xunit;

namespace SkyRoute.Api.Tests
{
    public class FlightSearchServiceTests
    {
        [Fact]
        public async Task SearchFlightsAsync_ReturnsResults()
        {
            var service = new FlightSearchService();
            var request = new FlightSearchRequest
            {
                Origin = "JFK",
                Destination = "LAX",
                DepartureDate = System.DateTime.UtcNow.Date.AddDays(7),
                Passengers = 1,
                CabinClass = "Economy"
            };

            var results = await service.SearchFlightsAsync(request, CancellationToken.None);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
