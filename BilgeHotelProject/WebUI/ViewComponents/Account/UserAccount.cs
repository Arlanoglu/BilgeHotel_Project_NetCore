using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Account;
using WebUI.Utilities;

namespace WebUI.ViewComponents.Account
{
    public class UserAccount : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var user = HttpContext.Session.GetObject<VMUserSession>("user");
            return View(user);
        }
    }
}
