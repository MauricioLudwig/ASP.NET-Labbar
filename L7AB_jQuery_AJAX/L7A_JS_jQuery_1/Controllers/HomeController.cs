using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L7A_JS_jQuery_1.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L7A_JS_jQuery_1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = DataManager.GetAllCustomers();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AuthorBox(int id)
        {
            var viewModel = DataManager.GetCustomerDetails(id);
            return PartialView("_AuthorBox", viewModel);
        }



        public IActionResult SingleCustomer(int id)
        {
            var viewModel = DataManager.GetCustomerDetails(id);
            return PartialView("Details", viewModel);
        }

        public IActionResult GetCustomer(int id)
        {
            var viewModel = DataManager.GetCustomerDetails(id);
            return Json(viewModel);
        }
    }
}
