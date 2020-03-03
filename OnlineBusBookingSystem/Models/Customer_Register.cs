using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusBookingSystem.Models
{
    public class Customer_Register
    {
        [Required(ErrorMessage = "Please enter your email Id")]
        [DataType(DataType.EmailAddress)]
        public string userId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter your gender")]
        public string userGender { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string userPassword { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        public long userPhone { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }

        public string role { get; set; }
    }
}