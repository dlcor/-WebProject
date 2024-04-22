using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LastWeb.ModelsFrontend
{
    public class ReviewData
    {
        [Required(ErrorMessage = "Enter your Name")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Invalid lenght of Name!")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Enter your Message")]
        [StringLength(200, MinimumLength = 40, ErrorMessage = "Invalid lenght of message!")]
        public string UserMessage {  get; set; }
    }
}