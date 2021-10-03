using System.Collections.Generic;

namespace Felipe.Backend.Locsonging.Domain
{
    public class Album
    {
        public string Id { get; set; }
        
        public string Title { get; set; }

        public Artist Artist { get; set; }

        public IEnumerable<Artist> Featuring { get; set; }

        public string Image { get; set; }
    }
}