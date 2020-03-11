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
        public int TotalSeat { get; set; }
        public int AvailableSeat { get; set; }
        public int BookedSeat { get; set; }
        public int Rate { get; set; }
    }
}