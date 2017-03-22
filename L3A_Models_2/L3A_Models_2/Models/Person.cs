using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L3A_Models_2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required!!")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Email required!!")]
        [EmailAddress]
        [Validations.EmailEndingStringValidation(new string[] { "acme.com", "ludwig.com", "damien.com" }, ErrorMessage = "Email must end with either acme, ludwig or damien.com")]
        public string Email { get; set; }
    }
}
