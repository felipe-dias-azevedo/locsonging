using Newtonsoft.Json;

namespace Felipe.Backend.Locsonging.DTO.Request
{
    public class LoginViewModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
