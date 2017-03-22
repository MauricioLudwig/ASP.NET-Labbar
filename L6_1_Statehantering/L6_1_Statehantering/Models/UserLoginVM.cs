using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L6_1_Statehantering.Models
{
    public class UserLoginVM
    {
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Save login")]
        public bool SaveLogin { get; set; }
    }
}
