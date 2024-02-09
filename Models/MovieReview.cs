using System.ComponentModel.DataAnnotations;

namespace team_gung_ho_coders_backend.Models;

public class MovieReview
{
    public int MovieReviewId { get; set; }
    [Required(ErrorMessage = "Movie review text is required to leave a movie review."), StringLength(500, ErrorMessage = "Your movie review text cannot exceed 500 characters.")]
    [Display(Name = "Movie Review")]
    public string? TextBody { get; set; }
    [Required(ErrorMessage = "A movie rating is required to leave a movie review."), Range(1,5, ErrorMessage = "Your movie rating can only be 1 through 5.")]
    [Display(Name = "Movie Rating")]
    public int MovieRating { get; set; }

}