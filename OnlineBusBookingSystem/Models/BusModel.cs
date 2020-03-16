using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusBookingSystem.Models
{
    public class BusModel
    {
        public int BusId { get; set; }
        public string BusNo { get; set; }
        public string BusType { get; set; }
        public string Source { get; set; }
        public string Destinationn { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int TotalSeat { get; set; }
        public int Rate { get; set; }
    }
}