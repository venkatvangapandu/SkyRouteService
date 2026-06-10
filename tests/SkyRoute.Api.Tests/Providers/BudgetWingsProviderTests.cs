using System.Threading;
using System.Threading.Tasks;
using SkyRoute.Api.Models;
using SkyRoute.Api.Providers;
using Xunit;

namespace SkyRoute.Api.Tests.Providers
{
    public class BudgetWingsProviderTests
    {
        [Fact]
        public async Task SearchFlightsAsync_ReturnsBudgetWingsResult()
        {
            var provider = new BudgetWingsProvider();
            var request = new FlightSearchRequest
            {
                Origin = "ORD",
                Destination = "MIA",
                DepartureDate = System.DateTime.UtcNow.Date.AddDays(14),
                Passengers = 1,
                CabinClass = "Economy"
            };

            var results = await provider.SearchFlightsAsync(request, CancellationToken.None);

            Assert.NotNull(results);
            Assert.Single(results);
            Assert.Equal("BudgetWings", results[0].Provider);
        }
    }
}
