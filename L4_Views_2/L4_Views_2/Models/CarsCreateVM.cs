using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L4_Views_2.Models
{
    public class CarsCreateVM
    {
        [Display(Name = "Make")]
        [Required(ErrorMessage = "required")]
        public string Brand { get; set; }

        [Display(Name = "Doors")]
        [Required(ErrorMessage = "required")]
        [Range(2, 4)]
        public int Doors { get; set; }

        [Display(Name = "Top speed")]
        [Required(ErrorMessage = "required")]
        [Range(1, 300)]
        public int TopSpeed { get; set; }
    }
}
