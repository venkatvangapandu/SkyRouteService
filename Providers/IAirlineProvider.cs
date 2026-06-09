using SkyRoute.Api.Models;

namespace SkyRoute.Api.Providers
{
    public interface IAirlineProvider
    {
        List<FlightSearchResult> SearchFlights(FlightSearchRequest request);
    }
}
