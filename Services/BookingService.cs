using SkyRoute.Api.Models;

namespace SkyRoute.Api.Services
{
    public class BookingService
    {
        public BookingResponse BookFlight(BookingRequest request)
        {
            return new BookingResponse
            {
                BookingReference = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                Status = "Confirmed"
            };
        }
    }
}
