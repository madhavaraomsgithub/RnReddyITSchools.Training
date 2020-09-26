using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RnReddyITSchools.Training.Web.Presentation.Models
{
    public class Customer
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Email ")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Please enter the valid Email Address")]
        [EmailAddress(ErrorMessage ="It is not valid email address. Please right email address")]
        public string Email { get; set; }

        [Display(Name = "Address Name")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }


        // Class name, method name, property Name - should start with captial letters . In case, if it is multiple words
        // First name = FirstName

        // Variable name should start with smallLetter .. In case, if it has multiple words, then 
        // firstName
    }


}
