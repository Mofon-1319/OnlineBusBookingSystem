using OnlineBusBookingSystem.DAL;
using OnlineBusBookingSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.BL
{
    public class User_Details
    {
        UserRepository userRepository = new UserRepository();

        public IEnumerable<Customer> CreateDB()
        {
            return userRepository.CreateDB();
        }

        public void Add(Customer customer)
        {
            userRepository.Add(customer);
        }

        public Customer login(Customer customer)
        {
            return userRepository.login(customer);
        }

        public IEnumerable<Customer> ViewCustomer()
        {
            return userRepository.ViewCustomer();
        }

        public Customer Fetch(string id)
        {
            return userRepository.Fetch(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            userRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            userRepository.DeleteCustomer(customer);
        }
    }
}
