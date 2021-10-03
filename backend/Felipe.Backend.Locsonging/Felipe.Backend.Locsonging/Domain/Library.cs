using System;
using System.Collections.Generic;

namespace Felipe.Backend.Locsonging.Domain
{
    public class Library
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<Song> Songs { get; set; }

        public User User { get; set; }
    }
}