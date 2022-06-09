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
        public IActionResult Index()
        {
            Exam sınav = new Exam {
            Id=1,Questions=new List<Question>{ new Question {Id=1,ExamId=1,ImageUrl="" } }
            };
            return View();
        }
    }
}
