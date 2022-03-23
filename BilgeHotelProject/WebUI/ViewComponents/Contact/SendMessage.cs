using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ObjectCreator creator = new ObjectCreator();
            var vmMessage = creator.FactoryMethod(ViewModels.VMMessage);
            return View(vmMessage);
        }
    }
}
