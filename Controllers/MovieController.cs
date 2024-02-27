using team_gung_ho_coders_backend.Models;
using team_gung_ho_coders_backend.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace team_gung_ho_coders_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase 
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieRepository _movieRepository;

        public MovieController(ILogger<MovieController> logger, IMovieRepository repository)
        {
            _logger = logger;
            _movieRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovie() 
        {
            return Ok(_movieRepository.GetAllMovie());
        }

        [HttpGet]
        [Route("{movieId:int}")]
        public ActionResult<Movie> GetMovieById(int movieId) 
        {
            var movie = _movieRepository.GetMovieById(movieId);
            if (movie == null) {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult<Movie> CreateMovie(Movie movie) 
        {
            if (!ModelState.IsValid || movie == null) {
                return BadRequest();
            }
            var newMovie = _movieRepository.CreateMovie(movie);
            return Created(nameof(GetMovieById), newMovie);
        }

        [HttpPut]
        [Route("{movieId:int}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult<Movie> UpdateMovie(Movie movie) 
        {
            if (!ModelState.IsValid || movie == null) {
                return BadRequest();
            }
            return Ok(_movieRepository.UpdateMovie(movie));
        }

        [HttpDelete]
        [Route("{movieId:int}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult DeleteMovie(int movieId) 
        {
            _movieRepository.DeleteMovieById(movieId); 
            return NoContent();
        }

    }
}