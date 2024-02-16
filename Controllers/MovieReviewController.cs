using team_gung_ho_coders_backend.Models;
using team_gung_ho_coders_backend.Repositories;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace team_gung_ho_coders_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieReviewController : ControllerBase 
    {
        private readonly ILogger<MovieReviewController> _logger;
        private readonly IMovieReviewRepository _movieReviewRepository;

        public MovieReviewController(ILogger<MovieReviewController> logger, IMovieReviewRepository repository)
        {
            _logger = logger;
            _movieReviewRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieReview>> GetMovieReview() 
        {
            return Ok(_movieReviewRepository.GetAllMovieReview());
        }

        [HttpGet]
        [Route("{movieReviewId:int}")]
        public ActionResult<MovieReview> GetMovieReviewById(int movieReviewId) 
        {
            var movieReview = _movieReviewRepository.GetMovieReviewById(movieReviewId);
            if (movieReview == null) {
                return NotFound();
            }
            return Ok(movieReview);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult<MovieReview> CreateMovieReview(MovieReview movieReview) 
        {
            if (!ModelState.IsValid || movieReview == null) {
                return BadRequest();
            }
            var newMovieReview = _movieReviewRepository.CreateMovieReview(movieReview);
            return Created(nameof(GetMovieReviewById), newMovieReview);
        }

    }
}