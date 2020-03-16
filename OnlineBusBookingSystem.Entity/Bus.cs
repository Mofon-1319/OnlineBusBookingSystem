using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusBookingSystem.Entity
{
    public class Bus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
