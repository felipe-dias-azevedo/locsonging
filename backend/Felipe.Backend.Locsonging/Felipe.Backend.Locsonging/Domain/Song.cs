namespace Felipe.Backend.Locsonging.Domain
{
    public class Song
    {
        public string Id { get; set; }
        
        public string Title { get; set; }

        public int Duration { get; set; }

        public string Storage { get; set; }

        public Album Album { get; set; }
    }
}