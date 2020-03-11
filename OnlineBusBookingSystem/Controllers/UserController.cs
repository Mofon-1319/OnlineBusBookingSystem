using OnlineBusBookingSystem.Entity;
using OnlineBusBookingSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBusBookingSystem.Models;
using OnlineBusBookingSystem.BL;

namespace OnlineBusBookingSystem.Controllers
{
    public class UserController : Controller
    {
        User_Details user_Details = new User_Details();
        public static Customer currentUser { get; set; }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Register")]
        public ActionResult Register_Get()
        {
            IEnumerable<Customer> customer = user_Details.CreateDB();
            return View();
        }
        
        [HttpPost]
        [ActionName("Register")]
        public ActionResult Register_Post(Customer_Register customer_Model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Customer customer = new Customer
                    {
                        userName = customer_Model.userName,
                        userGender = customer_Model.userGender,
                        userId = customer_Model.userId,
                        userPassword = customer_Model.userPassword,
                        userPhone = customer_Model.userPhone,
                        dateOfBirth = customer_Model.dateOfBirth,
                        role = "User"
                    };
                    user_Details.Add(customer);
                    TempData["User_Exists"] = null;
                    return RedirectToAction("Login");
                }
            }
            catch (Exception)
            {
                TempData["User_Exists"] = "User already exists";
            }
            return View();
        }

        [ActionName("Login")]
        public ActionResult Login_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login_Post(Customer_Login customer_Login)
        {
            Customer customer = new Customer
            {
                userId = customer_Login.userId,
                userPassword = customer_Login.userPassword
            };
            currentUser = user_Details.login(customer);
            return RedirectToAction("Welcome",currentUser);
            //if(role == "Admin")
            //{
            //    return RedirectToAction("Manage_User", "Admin");
            //}
            //else if(role == "User")
            //{
            //    return RedirectToAction("Welcome");
            //}
            //else
            //{
            //    return View();
            //}
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}