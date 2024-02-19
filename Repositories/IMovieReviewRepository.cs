using System.Collections.Generic;
using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Repositories;
public interface IMovieReviewRepository
{
    IEnumerable<MovieReview> GetAllMovieReview();
    MovieReview? GetMovieReviewById(int movieReviewId);
    MovieReview? CreateMovieReview(MovieReview newMovieReview);
    MovieReview? UpdateMovieReview(MovieReview newMovieReview);
    void DeleteMovieReviewById(int movieReviewId);
}