using System.ComponentModel.DataAnnotations;

namespace team_gung_ho_coders_backend.Models;

public class Movie
{
    public int MovieId { get; set; }
    [Required(ErrorMessage = "A movie title is required to search.")]
    [Display(Name = "Movie Title")]
    public string? MovieTitle { get; set; }
    [Required(ErrorMessage = "An image is required.")]
    [Display(Name = "Image")]
    public string? ImgUrl { get; set; }
}