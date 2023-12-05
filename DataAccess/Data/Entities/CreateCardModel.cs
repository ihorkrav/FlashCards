namespace DataAccess.Data.Entities
{
    public class CreateCardModel
    {
        public string? FrontData { get; set; }
        public string? FrontImg { get; set; }
        public string? BackData { get; set; }
        public string? BackImg { get; set; }
        public int? Priority { get; set; }
        public int DeckID { get; set; }

    }
}
