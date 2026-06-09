using SkyRoute.Api.Models;
using SkyRoute.Api.Providers;

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

        public List<FlightSearchResult> SearchFlights(FlightSearchRequest request)
        {
            var results = new List<FlightSearchResult>();
            foreach (var provider in _providers)
            {
                results.AddRange(provider.SearchFlights(request));
            }
            return results;
        }
    }
}
