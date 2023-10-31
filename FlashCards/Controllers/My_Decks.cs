using Microsoft.AspNetCore.Mvc;

namespace FlashCards.Controllers
{
    public class My_Decks : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
