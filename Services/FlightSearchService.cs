using SkyRoute.Api.Models;
using SkyRoute.Api.Providers;
using System.Threading;
using System.Threading.Tasks;

namespace SkyRoute.Api.Services
{
    public class FlightSearchService
    {
        private readonly List<IAirlineProvider> _providers;

        public FlightSearchService()
        {
            _providers = new List<IAirlineProvider>
            {
                new GlobalAirProvider(),
                new BudgetWingsProvider()
            };
        }

        public async Task<List<FlightSearchResult>> SearchFlightsAsync(FlightSearchRequest request, CancellationToken cancellationToken = default)
        {
            var results = new List<FlightSearchResult>();
            foreach (var provider in _providers)
            {
                var providerResults = await provider.SearchFlightsAsync(request, cancellationToken);
                results.AddRange(providerResults);
            }
            return results;
        }
    }
}
