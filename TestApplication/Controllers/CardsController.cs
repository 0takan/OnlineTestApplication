using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Interfaces;

namespace TestApplication.Controllers
{
    public class CardsController : Controller
    {
        private readonly ICards _cards;
       
        public CardsController(ICards icards)
        {
            _cards = icards;
        }
        public ViewResult Index()
        {
            var cards = _cards._AllCards;
            return View(cards);
        }
    }
}
