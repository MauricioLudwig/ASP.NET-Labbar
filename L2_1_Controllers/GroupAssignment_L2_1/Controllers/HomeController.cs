using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L2_1.Filter;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L2_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        // [NonAction]
        // [HttpGet]
        // [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        // [RequireHttps]
        // [ActionName("Time")]
        [TestFilter]
        public IActionResult Time()
        {
            var time = DateTime.Now;
            ViewBag.time = time;
            return View();
        }
    }
}
