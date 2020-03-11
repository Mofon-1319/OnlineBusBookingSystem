using OnlineBusBookingSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusBookingSystem.Models
{
    public class BusScheduleModel
    {
        public int ScheduleId { get; set; }
        public string Source { get; set; }
        public string Destinationn { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}