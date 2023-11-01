using FlashCards.Data;
using FlashCards.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlashCards.Controllers
{
    public class DecksManagerController : Controller
    {
        DeckDbContext ctx = new DeckDbContext();
        public IActionResult Index()
        {
            var decks = ctx.Decks.ToList();
            return View(decks);
        }

        public IActionResult Delete(int id)
        {
            var item = ctx.Decks.Find(id);

            if (item == null)
                return NotFound();
            else
            {
                ctx.Remove(item);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            
            return RedirectToAction("Index", "EditDeck", new { Id = id, CTX = ctx});
        }
    }
}
