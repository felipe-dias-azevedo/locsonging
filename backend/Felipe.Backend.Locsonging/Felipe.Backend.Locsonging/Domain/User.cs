using System;
using System.Collections.Generic;
using Felipe.Backend.Locsonging.Infrastructure;

namespace Felipe.Backend.Locsonging.Domain
{
    [MongoCollection("users")]
    public class User
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public IEnumerable<Song> Favorites { get; set; }
        
        public string SpotifyToken { get; set; }
        
    }
}