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
        public IEnumerable<Bus> CreateDB()
        {
            using (UserContext context = new UserContext())
            {
                return context.bus.ToList();
            }
        }
        public void AddBus(Bus bus)
        {
            using (UserContext context = new UserContext())
            {
                context.bus.Add(bus);
                context.SaveChanges();
            }
        }

        public IEnumerable<Bus> GetBus()
        {
            using (UserContext context = new UserContext())
            {
                return context.bus.ToList();
            }
        }


    }
}
