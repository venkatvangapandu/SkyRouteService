using SkyRoute.Api.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SkyRoute.Api.Providers
{
    public class GlobalAirProvider : IAirlineProvider
    {
        public Task<List<FlightSearchResult>> SearchFlightsAsync(FlightSearchRequest request, CancellationToken cancellationToken = default)
        {
            var baseFare = 200m;
            var surcharge = baseFare * 0.15m;
            var price = Math.Round(baseFare + surcharge, 2);

            var results = new List<FlightSearchResult>
            {
                new FlightSearchResult
                {
                    Provider = "GlobalAir",
                    FlightNumber = "GA123",
                    Origin = request.Origin,
                    Destination = request.Destination,
                    DepartureTime = request.DepartureDate.AddHours(8),
                    ArrivalTime = request.DepartureDate.AddHours(12),
                    Duration = TimeSpan.FromHours(4),
                    CabinClass = request.CabinClass,
                    PricePerPassenger = price,
                    TotalPrice = price * request.Passengers
                }
            };

            return Task.FromResult(results);
        }
    }
}
