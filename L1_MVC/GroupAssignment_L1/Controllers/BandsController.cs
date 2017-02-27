using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L1.Controllers
{
    public class BandsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var models = DataManager.GetAllBands();
            ViewBag.Bands = models;
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = DataManager.GetBand(id);
            ViewBag.Band = model;
            return View();
        }

        public IActionResult Albums(int id)
        {
            var model = DataManager.GetBand(id);
            ViewBag.Band = model;
            return View();
        }
    }
}
