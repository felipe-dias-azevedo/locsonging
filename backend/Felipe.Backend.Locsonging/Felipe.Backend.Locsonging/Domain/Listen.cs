using System;

namespace Felipe.Backend.Locsonging.Domain
{
    public class Listen
    {
        public string Id { get; set; }
        
        public DateTime When { get; set; }

        public Double MuchListened { get; set; }

        public Song Song { get; set; }

        public User User { get; set; }
    }
}