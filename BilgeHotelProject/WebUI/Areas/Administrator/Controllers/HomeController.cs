using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.CurrencyRate;
using WebUI.Utilities;

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
        public IActionResult GetCurrencyRate()
        {
            var data = ConvertXmlToClass<Tarih_Date>.ConvertXmlFrom("https://tcmb.gov.tr/kurlar/today.xml");
            if (data != null)
            {
                var result = data.Currency.Select(CurrencyModel.Map).ToArray();
                var json = JsonConvert.SerializeObject(result);

                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
