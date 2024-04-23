using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LastWeb.Domain.ModelsFrontend
{
    public class RegistrationData
    {
        [Required(ErrorMessage = "Enter a userName")]
        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Invalid lenght of userName!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Invalid lenght of password!")]
        public string Password { get; set; }
    }
}