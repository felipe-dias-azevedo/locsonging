using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Felipe.Backend.Locsonging.DTO.Request
{
    public class LoginViewModel
    {
        [Required]
        [JsonPropertyName("email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("password")]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
