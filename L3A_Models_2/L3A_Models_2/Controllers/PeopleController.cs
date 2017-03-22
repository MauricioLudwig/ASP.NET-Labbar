using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L3A_Models_2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L3A_Models_2.Controllers
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
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            DataManager.AddPerson(person);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = DataManager.GetPerson(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            DataManager.EditPerson(person);
            return RedirectToAction(nameof(Index));
        }
    }
}
