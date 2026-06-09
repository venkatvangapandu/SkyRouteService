using SkyRoute.Api.Models;

namespace SkyRoute.Api.Providers
{
    public class GlobalAirProvider : IAirlineProvider
    {
        public List<FlightSearchResult> SearchFlights(FlightSearchRequest request)
        {
            var baseFare = 200m;
            var surcharge = baseFare * 0.15m;
            var price = Math.Round(baseFare + surcharge, 2);

            return new List<FlightSearchResult>
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
        }
    }
}
