using Microsoft.AspNetCore.Mvc;
using QuizDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuiz _quizeRepo;
        public IActionResult Index()
        {
            return View();
        }
    }
}
