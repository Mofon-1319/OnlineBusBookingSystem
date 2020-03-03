using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBusBookingSystem.Entity
{
    public class Customer
    {
        [Key]
        [MaxLength(250)]
        public string userId { get; set; }
        [Required]
        [MaxLength(50)]
        public string userName { get; set; }
        [Required]
        [MaxLength(6)]
        public string userGender { get; set; }
        [Required]
        [MaxLength(25)]
        public string userPassword { get; set; }
        [Required]
        public long userPhone { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
        [Required]
        public string role { get; set; }

    }
}
