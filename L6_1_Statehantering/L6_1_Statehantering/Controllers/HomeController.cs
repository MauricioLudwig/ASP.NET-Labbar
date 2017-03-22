using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L6_1_Statehantering.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L6_1_Statehantering.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserLoginVM viewModel)
        {

            if (!ModelState.IsValid)
                return View(viewModel);

            if (viewModel.SaveLogin)
                Response.Cookies.Append("Username", viewModel.Name, new Microsoft.AspNetCore.Http.CookieOptions { Expires = DateTime.Now.AddSeconds(10) });
            else
                Response.Cookies.Append("Username", viewModel.Name);

            return RedirectToAction(nameof(HomeController.Profile));
        }

        public IActionResult Profile()
        {
            var model = new UserProfileVM { Name = Request.Cookies["Username"] };
            return View(model);
        }
    }
}
