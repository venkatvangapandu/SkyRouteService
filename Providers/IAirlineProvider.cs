using SkyRoute.Api.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SkyRoute.Api.Providers
{
    public interface IAirlineProvider
    {
        Task<List<FlightSearchResult>> SearchFlightsAsync(FlightSearchRequest request, CancellationToken cancellationToken = default);
    }
}
