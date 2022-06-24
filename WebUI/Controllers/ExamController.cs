using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ExamController : Controller
    {
        IExamService _examService;
        IUserResultService _resultService;

        public ExamController(IExamService examService, IUserResultService resultService)
        {
            _examService = examService;
            _resultService = resultService;
        }
        [HttpGet]
        public IActionResult Index(string Kod)
        {
            ViewBag.Kod = Kod;
            var result= _examService.GetByExamDetails(Kod);
            return View(result.Data);
        }
        [HttpPost]
        public IActionResult Index(List<string> results)
        {
            UserResult userResult = new UserResult();
            //userResult.ExamKod = ViewBag.Kod;
            userResult.Email = TempData["Email"].ToString();
            userResult.ExamKod = TempData["Kod"].ToString();
            var result = _resultService.Add(results,userResult);
            return View("Info");
        }
    }
}
