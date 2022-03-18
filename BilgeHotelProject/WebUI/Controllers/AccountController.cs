using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        public IActionResult Register()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Register()
        //{
        //    return View();
        //}
    }
}
