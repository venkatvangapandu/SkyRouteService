using Microsoft.AspNetCore.Mvc;
using SkyRoute.Api.Models;
using SkyRoute.Api.Services;
using System.Threading;
using System.Threading.Tasks;

namespace SkyRoute.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly FlightSearchService _flightSearchService;
        private readonly BookingService _bookingService;

        public FlightsController(FlightSearchService flightSearchService, BookingService bookingService)
        {
            _flightSearchService = flightSearchService;
            _bookingService = bookingService;
        }

        [HttpPost("search")]
        public async Task<IActionResult> SearchFlights([FromBody] FlightSearchRequest request, CancellationToken cancellationToken)
        {
            var results = await _flightSearchService.SearchFlightsAsync(request, cancellationToken);
            return Ok(results);
        }

        [HttpPost("book")]
        public IActionResult BookFlight([FromBody] BookingRequest request)
        {
            var response = _bookingService.BookFlight(request);
            return Ok(response);
        }
    }
}
