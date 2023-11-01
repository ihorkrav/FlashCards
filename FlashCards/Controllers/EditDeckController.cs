using FlashCards.Data;
using FlashCards.Data.Entities;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlashCards.Controllers
{
    
    public class EditDeckController : Controller
    {
       
        public IActionResult Index(int Id, DeckDbContext CTX)
        {
            
            DeckData data = new DeckData();
            data.Deck = CTX.Decks.Find(Id);
            data.Cards = CTX.Cards.Where(d => d.DeckID == Id-1).ToList();
            return View(data);
        }
    }
}
