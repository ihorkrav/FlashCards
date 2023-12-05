using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FlashCards.Controllers
{
    
    public class EditDeckController : Controller
    {
        private readonly DeckDbContext ctx;
        private readonly int Id;

        public EditDeckController( DeckDbContext ctx) // Dependency Injection
        {
            this.ctx = ctx;
        }
        public IActionResult Index(int Id)
        {
            
            DeckData data = new DeckData();
            data.Deck = ctx.Decks.Find(Id);
            var cards = ctx.Cards;
            data.Cards = ctx.Cards.Where(d => d.DeckID == Id).ToList();
         
            if (data.Cards.Count() == 0)
            {
                data.Cards.Add(new Card());
            }
            return View(data);
        }
        [HttpPost]
        public IActionResult Add(string FrontData, string BackData, int DeckID)
        {
            
            Card card = new Card();
           

            card.FrontData = FrontData;             
            card.BackData = BackData;
            card.DeckID = DeckID;
            //card.Id = ctx.Cards.Where(d => d.DeckID == card.DeckID - 1).Count();
            //card.Id = 1;
            ctx.Cards.Add(card);
            ctx.SaveChanges();
            return RedirectToAction("Index", new { Id = card.DeckID });
        }
        public IActionResult Delete(int id)
        {
            ctx.Cards.Remove(ctx.Cards.Where(c=>c.Id == id).FirstOrDefault());
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SaveChanges(DeckDbContext dbc)
        {
            return RedirectToAction("Update", "DecksManager", new {  ctx_ = dbc });
        }
    }
}
