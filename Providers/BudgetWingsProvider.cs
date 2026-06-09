using SkyRoute.Api.Models;

namespace SkyRoute.Api.Providers
{
    public class BudgetWingsProvider : IAirlineProvider
    {
        public List<FlightSearchResult> SearchFlights(FlightSearchRequest request)
        {
            var baseFare = 180m;
            var discount = baseFare * 0.10m;
            var price = Math.Max(baseFare - discount, 29.99m);

            return new List<FlightSearchResult>
            {
                new FlightSearchResult
                {
                    Provider = "BudgetWings",
                    FlightNumber = "BW456",
                    Origin = request.Origin,
                    Destination = request.Destination,
                    DepartureTime = request.DepartureDate.AddHours(10),
                    ArrivalTime = request.DepartureDate.AddHours(14),
                    Duration = TimeSpan.FromHours(4),
                    CabinClass = request.CabinClass,
                    PricePerPassenger = price,
                    TotalPrice = price * request.Passengers
                }
            };
        }
    }
}
