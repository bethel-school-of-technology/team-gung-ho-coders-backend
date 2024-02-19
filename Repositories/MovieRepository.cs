using System.Collections.Generic;
using team_gung_ho_coders_backend.Migrations;
using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Repositories;

public class MovieRepository : IMovieRepository 
{
    private readonly MovieDbContext _context;

    public MovieRepository(MovieDbContext context)
    {
        _context = context;
    }

    public Movie CreateMovie(Movie newMovie)
    {
        _context.Movie.Add(newMovie);
        _context.SaveChanges();
        return newMovie;
    }

    public IEnumerable<Movie> GetAllMovie()
    {
        return _context.Movie.ToList();
    }

    public Movie? GetMovieById(int movieId)
    {
        return _context.Movie.SingleOrDefault(c => c.MovieId == movieId);
    }

    public Movie? UpdateMovie(Movie newMovie)
    {
        var originalMovie = _context.Movie.Find(newMovie.MovieId);
        if (originalMovie != null) {
            originalMovie.MovieTitle = newMovie.MovieTitle;
            originalMovie.ImgUrl = newMovie.ImgUrl;
            _context.SaveChanges();
        }
        return originalMovie;
    }

        public void DeleteMovieById(int movieId)
    {
        var movie = _context.Movie.Find(movieId);
        if (movie != null) {
            _context.Movie.Remove(movie); 
            _context.SaveChanges(); 
        }
    }

}