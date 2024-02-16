using team_gung_ho_coders_backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IAuthService _authService;

    public AuthController(ILogger<AuthController> logger, IAuthService service)
    {
        _logger = logger;
        _authService = service;
    }

    [HttpPost]
    [Route("register")]
    public ActionResult CreateUser(User user)
    {
        if (user == null || !ModelState.IsValid)
        {
            return BadRequest();
        }
        _authService.CreateUser(user);
        return NoContent();
    }

    [HttpPost]
    [Route("login")]
    public ActionResult<string> SignIn(User user)
    {
        if (string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.Password))
        {
            return BadRequest();
        }

        var token = _authService.SignIn(user);

        if (string.IsNullOrWhiteSpace(token))
        {
            return Unauthorized();
        }

        return Ok(token);
    }
}
