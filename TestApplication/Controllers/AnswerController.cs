using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswer _answerRepo;
        private readonly ILogger<AnswerController> _logger;

        public AnswerController(IAnswer answerRepo, ILogger<AnswerController> logger)
        {
            _answerRepo = answerRepo;
            _logger = logger;
        }

        //GET: ANSWER
        public IActionResult Index()
        {
            var answer = _answerRepo.GetAllAnswer();
            return View(_answerRepo.GetAllAnswer());
        }

        //GET: ANSWER/1
        public IActionResult Details(int id)
        {
            return View(_answerRepo.GetById(id));
        }

    }
}
