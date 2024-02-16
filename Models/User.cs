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
    [Required (ErrorMessage = "A password is required."), ]
    [Display(Name = "Password")]
    public string? Password { get; set; }
}
