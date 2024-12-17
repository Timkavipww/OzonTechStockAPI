namespace Ozon.Edu.StockAPI.Controllers;

[ApiController]
[Route("v1/api/jwt")]
public class JwtController : ControllerBase
{
    private readonly IAuthService _authService;

    public JwtController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public async Task<ActionResult> GetJwt()
    {
        var jwt = _authService.PrintJWTSettings();

        return Ok(jwt);
    }
}
