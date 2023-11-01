using FlashCards.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlashCards.Data
{
    public class DeckDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CardsDb;Integrated Security=True; MultipleActiveResultSets=true; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

            modelBuilder.Entity<Card>().HasData(new[]
            {
                new Card{Id = 1 ,FrontData = "2+2 = ?", BackData = "4", Priority = 1, DeckID = 1},
                new Card{Id = 2 ,FrontData = "2*2 = ?", BackData = "4", Priority = 1, DeckID = 1},
                new Card{Id = 3 ,FrontData = "2^2 = ?", BackData = "4", Priority = 1, DeckID = 1},
                new Card{Id = 4 ,FrontData = "4*4 = ?", BackData = "16", Priority = 1, DeckID = 1},
                new Card{Id = 5 ,FrontData = "3^2 = ?", BackData = "9", Priority = 1, DeckID = 1},
                new Card{Id = 6 ,FrontData = "9+8 = ?", BackData = "17", Priority = 1, DeckID = 1},
                new Card{Id = 7 ,FrontData = "22+11 = ?", BackData = "33", Priority = 1, DeckID = 1},
                new Card{Id = 8 ,FrontData = "33+48 = ?", BackData = "81", Priority = 1, DeckID = 1},
                new Card{Id = 9 ,FrontData = "55+5 = ?", BackData = "60", Priority = 1, DeckID = 1},
               
            });

        }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
