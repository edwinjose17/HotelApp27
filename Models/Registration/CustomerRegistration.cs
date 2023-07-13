using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace HotelApp.Models.Registration
{
    public class CustomerRegistration
    {
        [Required]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Second Name")]
        public string secondName { get; set; }

        [Required]
        [Display(Name = "D.O.B")]

        public DateTime dateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "Contact Number")]

        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "State")]
        public string state { get; set; }

        [Required]
        [Display(Name = "City")]

        public string city { get; set; }

        [Required]
        [Display(Name = "Username")]

        public string username { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}