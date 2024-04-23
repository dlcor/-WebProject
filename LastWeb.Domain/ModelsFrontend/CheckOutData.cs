using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LastWeb.Domain.ModelsFrontend
{
    public class CheckOutData
    {
        [Required(ErrorMessage = "Name")]
        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Username must be at least 1 characters long")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Username must be at least 1 characters long")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please provide an email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide a phone number")]
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }
        
        public ProductQuantity[] productQuantities { get; set; }
    }
}