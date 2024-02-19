using System.Collections.Generic;
using team_gung_ho_coders_backend.Migrations;
using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Repositories;

public class MovieReviewRepository : IMovieReviewRepository 
{
    private readonly MovieDbContext _context;

    public MovieReviewRepository(MovieDbContext context)
    {
        _context = context;
    }

    public MovieReview CreateMovieReview(MovieReview newMovieReview)
    {
        _context.MovieReview.Add(newMovieReview);
        _context.SaveChanges();
        return newMovieReview;
    }

    public IEnumerable<MovieReview> GetAllMovieReview()
    {
        return _context.MovieReview.ToList();
    }

    public MovieReview? GetMovieReviewById(int movieReviewId)
    {
        return _context.MovieReview.SingleOrDefault(c => c.MovieReviewId == movieReviewId);
    }

    public MovieReview? UpdateMovieReview(MovieReview newMovieReview)
    {
        var originalMovieReview = _context.MovieReview.Find(newMovieReview.MovieReviewId);
        if (originalMovieReview != null) {
            originalMovieReview.TextBody = newMovieReview.TextBody;
            originalMovieReview.MovieRating = newMovieReview.MovieRating;
            _context.SaveChanges();
        }
        return originalMovieReview;
    }

        public void DeleteMovieReviewById(int movieReviewId)
    {
        var movieReview = _context.MovieReview.Find(movieReviewId);
        if (movieReview != null) {
            _context.MovieReview.Remove(movieReview); 
            _context.SaveChanges(); 
        }
    }
}