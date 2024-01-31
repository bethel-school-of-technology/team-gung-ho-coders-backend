using System.ComponentModel.DataAnnotations;

namespace team_gung_ho_coders_backend.Models;

public class MovieSearch
{
    public int MovieSearchId { get; set; }
    [Required(ErrorMessage = "A movie title is required to search.")]
    [Display(Name = "Movie Title")]
    public string? MovieTitle { get; set; }

}