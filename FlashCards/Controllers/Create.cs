using Microsoft.AspNetCore.Mvc;

namespace FlashCards.Controllers
{
    public class Create : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
