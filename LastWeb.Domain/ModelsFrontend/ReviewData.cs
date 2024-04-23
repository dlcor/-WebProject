using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Web;

namespace LastWeb.Domain.ModelsFrontend
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