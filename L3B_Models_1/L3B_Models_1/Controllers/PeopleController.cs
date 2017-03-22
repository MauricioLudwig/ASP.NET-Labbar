using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L3B_Models_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L3B_Models_1.Controllers
{
    public class PeopleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = DataManager.GetAllPeople();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PeopleCreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            DataManager.AddPerson(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
