namespace FlashCards.Data.Entities
{
    public class DeckData
    {
        public List<Card> Cards { get; set; }
        public Deck Deck { get; set; }
        public DeckData()
        {
            this.Cards = new List<Card>();
            this.Deck = new Deck();
        }
    }
}
