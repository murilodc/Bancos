using Microsoft.AspNetCore.Mvc;
using TesteTecnicoBancos.Infrastructure.Authentication;

namespace TesteTecnicoBancos.Api.Controllers;
[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;
    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Communication.Requests.LoginRequest model)
    {
        if (model.Username != "admin" || model.Password != "admin")
        {
            return Unauthorized(new { message = "Usuário ou senha inválidos, usuario padrão = admin e senha padrão = admin"});
        }

        var token = _jwtService.GenerateToken(model.Username, "Admin");

        return Ok(new { Token = token });
    }
}
