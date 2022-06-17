using System.Text.Json.Serialization;

namespace Felipe.Backend.Locsonging.DTO.Request
{
    public class LoginViewModel
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
