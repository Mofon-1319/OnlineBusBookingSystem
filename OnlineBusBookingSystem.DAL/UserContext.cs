using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineBusBookingSystem.Entity;

namespace OnlineBusBookingSystem.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Connection")
        {

        }
        public DbSet<Customer> user {get; set;}
        public DbSet<Bus> bus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>().MapToStoredProcedures();
        }
    }
}
