using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.Entity
{
    public class Bus
    {
        [Key]
        public int BusId { get; set; }
        [Index(IsUnique =true)]
        public string BusNo { get; set; }
        public int TotalSeat { get; set; }
        public int AvailableSeat { get; set; }
        public int BookedSeat { get; set; }
        public int Rate { get; set; }
    }
}
