using Microsoft.AspNetCore.Mvc;
using SkyRoute.Api.Models;
using SkyRoute.Api.Services;

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
        public IActionResult SearchFlights([FromBody] FlightSearchRequest request)
        {
            var results = _flightSearchService.SearchFlights(request);
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
