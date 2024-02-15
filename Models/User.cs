using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace team_gung_ho_coders_backend.Models;

public class User 
{
    [JsonIgnore]
    public int UserId { get; set; }

    [Required (ErrorMessage = "A username is required."), ]
    [Display(Name = "?User Name")]
    public string? UserName { get; set; }
    [Required (ErrorMessage = "A password is required."), Range (12,36, ErrorMessage = "Your password should be between 12 and 24 characters long.")]
    [Display(Name = "Password")]
    public string? Password { get; set; }
}
