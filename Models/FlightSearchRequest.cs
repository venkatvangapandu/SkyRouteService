namespace SkyRoute.Api.Models
{
    public class FlightSearchRequest
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Passengers { get; set; }
        public string CabinClass { get; set; }
    }
}
