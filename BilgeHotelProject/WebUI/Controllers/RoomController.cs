using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            //Todo: RoomDetail view i ve action'ı oluşturulacak parametre id alacak ve o idye ait roomtype ini return edecek. Ancak bu sayfada aynı zamanda bir form olup post işlemi yapılacağı için roomtype view component olarak ayarlanabilir. Üzerinde düşünülecek.
            return View();
        }
    }
}
