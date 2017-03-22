using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L6_2_Statehantering.Models;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L6_2_Statehantering.Controllers
{
    public class SettingsController : Controller
    {

        IMemoryCache cache;

        public SettingsController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCompanyVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            cache.Set("email", viewModel.Email);

            return RedirectToAction(nameof(SettingsController.Display));
        }

        [HttpGet]
        public IActionResult Display()
        {
            return View();
        }
    }
}
