using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestion _questionRepo;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestion questionRepo, ILogger<QuestionController> logger)
        {
            _questionRepo = questionRepo;
            _logger = logger;
        }

        //GET: QUESTION
        public IActionResult Index()
        {
            var question = _questionRepo.ListAllQuestions();
            return View(_questionRepo.ListAllQuestions());
        }

        //GET: QUESTION/1
        public IActionResult Details(int id)
        {
            return View(_questionRepo.GetById(id));
        }
    }
}
