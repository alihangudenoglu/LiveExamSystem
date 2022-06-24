using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Kod)
        {
            ViewBag.Date = "23.06.2022 17:55";
            ViewBag.Kod = Kod;
            return View("WaitRoom");
        }
    }
}
