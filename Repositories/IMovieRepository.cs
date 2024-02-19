using System.Collections.Generic;
using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Repositories;
public interface IMovieRepository
{
    IEnumerable<Movie> GetAllMovie();
    Movie? GetMovieById(int movieId);
    Movie? CreateMovie(Movie newMovie);
    Movie? UpdateMovie(Movie newMovie);
    void DeleteMovieById(int movieId);

}