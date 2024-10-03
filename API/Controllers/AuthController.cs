namespace DefaultNamespace;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IJwtTokenService _jwtTokenService;

    public AuthController(IUserService userService, IJwtTokenService jwtTokenService)
    {
        _userService = userService;
        _jwtTokenService = jwtTokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UsuarioDto loginDto)
    {
        var user = _userService.ValidateUser(loginDto.Email, loginDto.Password);
        if (user == null)
        {
            return Unauthorized("Invalid credentials");
        }

        var token = _jwtTokenService.GenerateToken(user);
        return Ok(new { Token = token });
    }
}
