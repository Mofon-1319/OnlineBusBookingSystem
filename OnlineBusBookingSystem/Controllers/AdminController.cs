using OnlineBusBookingSystem.BL;
using OnlineBusBookingSystem.DAL;
using OnlineBusBookingSystem.Entity;
using OnlineBusBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBusBookingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        User_Details user_Details = new User_Details();
        IEnumerable<Customer> userList;

        public ActionResult Manage_User()
        {
            userList = user_Details.ViewCustomer();
            return View(userList);
        }

        [HttpGet]
        public ActionResult Edit(Customer user)
        {
            //var updated = userList.Where(s => s.userId == id).FirstOrDefault();
            Customer customer = user_Details.Fetch(user.userId);
            return View(customer);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Customer(Customer_Register customer)
        {
            Customer updatedCustomer = new Customer();
            updatedCustomer.userId = customer.userId;
            updatedCustomer.userName = customer.userName;
            updatedCustomer.userPassword = customer.userPassword;
            updatedCustomer.role = customer.role;
            updatedCustomer.dateOfBirth = customer.dateOfBirth;
            updatedCustomer.userPhone = customer.userPhone;
            updatedCustomer.userGender = customer.userGender;
            user_Details.UpdateCustomer(updatedCustomer);
            return RedirectToAction("Manage_User");
        }

        public ActionResult Delete(Customer user)
        {
            Customer customer = user_Details.Fetch(user.userId);
            user_Details.DeleteCustomer(customer);
            return RedirectToAction("Manage_User");
        }
    }
}