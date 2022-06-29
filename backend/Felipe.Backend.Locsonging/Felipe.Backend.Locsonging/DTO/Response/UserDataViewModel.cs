using System;

namespace Felipe.Backend.Locsonging.DTO.Response
{
    public class UserDataViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string SpotifyToken { get; set; }
    }
}
