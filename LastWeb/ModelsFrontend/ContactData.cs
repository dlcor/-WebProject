using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LastWeb.ModelsFrontend
{
    public class ContactData
    {
        [Required(ErrorMessage = "Enter a userName")]
        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Invalid lenght of userName!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a subject")]
        [Display(Name = "Subject")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Invalid lenght of subject!")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Enter a message")]
        [Display(Name = "Message")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Invalid lenght of message!")]
        public string Message { get; set; }
    }
}