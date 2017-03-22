using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L4_Views_2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L4_Views_2.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = DataManager.ListCars();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            DataManager.AddCar(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
