using DataAccess.Data;

using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlashCards.Controllers
{
    public class DecksManagerController : Controller
    {
        DeckDbContext ctx ;
        public DecksManagerController(DeckDbContext ctx) // Dependency Injection
        {
            this.ctx = ctx;
        }
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
        public IActionResult Update(DeckDbContext ctx_)
        {
            ctx = ctx_;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            
            return RedirectToAction("Index", "EditDeck", new { Id = id, CTX = ctx});
        }
    }
}
