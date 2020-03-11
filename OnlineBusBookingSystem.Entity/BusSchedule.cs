using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.Entity
{
    public class BusSchedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public string Source { get; set; }
        public string Destinationn { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}
