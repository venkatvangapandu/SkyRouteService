using System.Threading;
using System.Threading.Tasks;
using SkyRoute.Api.Models;
using SkyRoute.Api.Providers;
using Xunit;

namespace SkyRoute.Api.Tests.Providers
{
    public class GlobalAirProviderTests
    {
        [Fact]
        public async Task SearchFlightsAsync_ReturnsGlobalAirResult()
        {
            var provider = new GlobalAirProvider();
            var request = new FlightSearchRequest
            {
                Origin = "JFK",
                Destination = "LAX",
                DepartureDate = System.DateTime.UtcNow.Date.AddDays(7),
                Passengers = 2,
                CabinClass = "Business"
            };

            var results = await provider.SearchFlightsAsync(request, CancellationToken.None);

            Assert.NotNull(results);
            Assert.Single(results);
            Assert.Equal("GlobalAir", results[0].Provider);
        }
    }
}
