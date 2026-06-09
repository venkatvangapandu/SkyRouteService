namespace SkyRoute.Api.Models
{
    public class FlightSearchResult
    {
        public string Provider { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string CabinClass { get; set; }
        public decimal PricePerPassenger { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
