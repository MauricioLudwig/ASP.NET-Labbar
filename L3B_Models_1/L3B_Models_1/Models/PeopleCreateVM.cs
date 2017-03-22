using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L3B_Models_1.Models
{
    public class PeopleCreateVM
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Display(Name = "I Accept the terms & conditions")]
        [ValidateAttributes.Checkbox(true, ErrorMessage = "")]
        public bool AcceptTerms { get; set; }
    }
}
