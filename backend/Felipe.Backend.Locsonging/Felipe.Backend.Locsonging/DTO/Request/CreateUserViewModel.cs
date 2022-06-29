using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Felipe.Backend.Locsonging.DTO.Request
{
    public class CreateUserViewModel
    {
        [Required]
        [JsonPropertyName("userName")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [JsonPropertyName("email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("password")]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [JsonPropertyName("birthDate")]
        // TODO: Validate if birth date is older than now (minimum 18 yo)
        // birthDate <= (now - 18 years) 
        public DateTime BirthDate { get; set; }
    }
}
