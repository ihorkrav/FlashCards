namespace DataAccess.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string? FrontData { get; set; }
        public string? FrontImg { get; set; }
        public string? BackData { get; set; }
        public string? BackImg { get; set; }
        public int Priority { get; set; }
        public int DeckID { get; set; }
    }
}
