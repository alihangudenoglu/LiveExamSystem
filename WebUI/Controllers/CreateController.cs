using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class CreateController : Controller
    {
        IExamService _examService;

        public CreateController(IExamService examService)
        {
            _examService = examService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(List<IFormFile> formFile,[FromForm]Exam exam)
        {
            var result = _examService.Add(formFile, exam);
            if (result.Success)
            {
                return RedirectToAction("Success", new { kod = exam.ExamKod });
            }
            
            return View();
        }
        
        public IActionResult Success(string kod)
        {
            ViewBag.result = kod;
            return View();
        }
    }
}
