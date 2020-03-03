using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBusBookingSystem.Models
{
    public class Customer_Login
    {
        [Required(ErrorMessage = "Please enter your email Id")]
        [DataType(DataType.EmailAddress)]
        public string userId { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string userPassword { get; set; }
    }
}