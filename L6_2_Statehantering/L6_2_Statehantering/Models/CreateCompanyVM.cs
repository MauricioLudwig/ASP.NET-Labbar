using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L6_2_Statehantering.Models
{
    public class CreateCompanyVM
    {
        [Display(Name = "Company Name")]
        [Required]
        public string CompanyName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
