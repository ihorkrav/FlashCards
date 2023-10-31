using FlashCards.Data;
using FlashCards.Data.Entities;
using FlashCards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlashCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //List<Decks> Decks = new List<Decks>;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        DeckDbContext db = new DeckDbContext();
        public IActionResult Index()
        {
            var decks = db.Decks.ToList();
            return View(decks);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}