namespace DataAccess.Data.Entities
{
    public class DeckData
    {
        public List<Card> Cards { get; set; }
        public Deck Deck { get; set; }
        public CreateCardModel? CreateCardModel { get; set; }    
        public CreateDeckModel? CreateDeckModel { get; set; }
        public DeckData()
        {
            this.Cards = new List<Card>();
            this.Deck = new Deck();
            this.CreateCardModel = new CreateCardModel();
            this.CreateDeckModel = new CreateDeckModel();
        }
    }
}
