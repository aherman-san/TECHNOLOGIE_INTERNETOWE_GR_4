namespace NetflixGrupaCzwarta.Entites
{
    public class Movie
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public int Year { get; set; }
        public List<string> Cast { get; set; } = new List<string>();
        public bool IsPromoted { get; set; }
    }
}
