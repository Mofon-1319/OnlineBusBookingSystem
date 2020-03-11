using OnlineBusBookingSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.DAL
{
    public class BusRepository
    {
        public void AddBus(Bus bus)
        {
            using (BusContext context = new BusContext())
            {
                context.bus.Add(bus);
                context.SaveChanges();
            }
        }

        public void AddBusSchedule(BusSchedule schedule)
        {
            using (BusContext context = new BusContext())
            {
                context.busSchedule.Add(schedule);
                context.SaveChanges();
            }
        }

        public IEnumerable<Bus> GetBus()
        {
            using (BusContext context = new BusContext())
            {
                return context.bus.ToList();
            }
        }


    }
}
