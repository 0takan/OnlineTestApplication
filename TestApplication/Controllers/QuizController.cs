using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<QuizController> _logger;

        public QuizController(IQuiz quizRepo, ILogger<QuizController> logger)
        {
            _quizeRepo = quizRepo;
            _logger = logger;
        }
        //GET: Quiz
        public IActionResult Index()
        {
            var quiz = _quizeRepo.ListAllQuizzes();
            return View(_quizeRepo.ListAllQuizzes());
        }

        //GET: Quiz/1
        public IActionResult Details(int id)
        {
            return View(_quizeRepo.GetById(id));
        }
    }
}
