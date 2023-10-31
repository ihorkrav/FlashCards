using FlashCards.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlashCards.Data
{
    public class DeckDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CardsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Deck>().HasData(new[]
            {
                new Deck{Id = 1 ,Title="New card", AmountOfCards = 340},
                new Deck{Id = 2 ,Title="New card1", AmountOfCards = 350},
                new Deck{Id = 3 ,Title="New card2", AmountOfCards = 60},
                new Deck{Id = 4 ,Title="New card3", AmountOfCards = 8},
                new Deck{Id = 5 ,Title="New card4", AmountOfCards = 10},
                new Deck{Id = 6 ,Title="New card5", AmountOfCards = 70},
                new Deck{Id = 7 ,Title="New card6", AmountOfCards = 70},
                new Deck{Id = 8 ,Title="New card7", AmountOfCards = 15},
                new Deck{Id = 9 ,Title="New card8", AmountOfCards = 20},
                new Deck{Id = 10 ,Title="New card9", AmountOfCards = 12}
            });
        }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
