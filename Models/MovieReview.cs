using System.ComponentModel.DataAnnotations;

namespace team_gung_ho_coders_backend.Models;

public class MovieReview
{
    public int MovieReviewId { get; set; }
    [Required(ErrorMessage = "A movie review is required."), StringLength(500, ErrorMessage = "Movie review length cannot exceed 500 characters.")]
    [Display(Name = "Movie Review")]

    public string? Description { get; set; }
    [Required(ErrorMessage = "A movie rating is required."), Range(1, 5, ErrorMessage = "You must enter a rating between 1 and 5.")]
    [Display(Name = "Movie Rating")]

    public int MovieRating { get; set; }
}