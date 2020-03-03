using OnlineBusBookingSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.DAL
{
    public class UserRepository
    {
        UserContext userContext = new UserContext();
        public IEnumerable<Customer> CreateDB()
        {
            return userContext.user.ToList();
        }

        public void Add(Customer customer)
        {
            userContext.user.Add(customer);
            userContext.SaveChanges();
        }

        public Customer login(Customer customer)
        {
            List<Customer> list = userContext.user.ToList();
            foreach (var items in list)
            {
                if (customer.userId == items.userId && customer.userPassword == items.userPassword)
                {
                    return items;
                }
            }
            return null;
        }
        public IEnumerable<Customer> ViewCustomer()
        {
            List<Customer> userList = userContext.user.ToList();
            return userList;
        }

        public Customer Fetch(string id)
        {
            UserContext userContext = new UserContext();
            //List<Customer> userList = userContext.user.ToList();
            Customer customer = new Customer();
            customer=userContext.user.Where(model => model.userId == id).SingleOrDefault();
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            userContext.Entry(customer).State = EntityState.Modified;
            userContext.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            userContext.user.Attach(customer);
            userContext.user.Remove(customer);
            userContext.SaveChanges();
        }
    }
}