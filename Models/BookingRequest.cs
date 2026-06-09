namespace SkyRoute.Api.Models
{
    public class BookingRequest
    {
        public FlightSearchResult Flight { get; set; }
        public List<PassengerInfo> Passengers { get; set; }
    }
}
