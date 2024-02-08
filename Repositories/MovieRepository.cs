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

}