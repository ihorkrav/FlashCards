using DataAccess.Data;
using DataAccess.Data.Entities;
using FlashCards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlashCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DeckDbContext dbc;
        //List<Decks> Decks = new List<Decks>;
        public HomeController( DeckDbContext dbc)
        {
            this.dbc = dbc;
        }

        public IActionResult Index()
        {
            var decks = dbc.Decks.ToList();
            return View(decks);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}