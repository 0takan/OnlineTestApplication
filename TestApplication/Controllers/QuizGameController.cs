using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuizDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Areas.Identity.Data;
using TestApplication.Data;

namespace TestApplication.Controllers
{
    public class QuizGameController : Controller
    {
        private readonly AuthDbContext _acc;

        private QuizGameController(AuthDbContext acc)
        {
            acc = _acc;
        }
        public IEnumerable<QuizTry2> displayresult { get; set; }
        public IActionResult GetQuiz()
        {

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
