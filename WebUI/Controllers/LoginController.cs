using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        IExamService _examService;

        public LoginController(IExamService examService)
        {
            _examService = examService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Kod,string Email)
        {
            var result = _examService.GetAll(Kod);
            
            ViewBag.finish_Date = result.Data.EndDateTime;
            ViewBag.start_Date = result.Data.StartDateTime;
            ViewBag.Kod = Kod;
            TempData["Email"] = Email;
            TempData["Kod"] = Kod;
            return View("WaitRoom");
        }
    }
}
