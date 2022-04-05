using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "admin,bilgi islem,resepsiyon,yardimci hizmetler,muhasebe,insan kaynaklari,mutfak")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
