using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace team_gung_ho_coders_backend.Models;

public class User
{
    [JsonIgnore]
    public int UserId { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required, Range(12, 20, ErrorMessage = "You must enter a Username between 12 and 20 characters.")]
    
    public string? Username { get; internal set; }
}