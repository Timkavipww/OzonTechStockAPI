namespace Ozon.Edu.StockAPI.Services;

public class AuthService : IAuthService
{
    private readonly JWT _jwt;

    public AuthService(IOptions<JWT> jwtOptions)
    {
        _jwt = jwtOptions.Value;
    }

    public string PrintJWTSettings()
    {
        return $"{_jwt.Key} {_jwt.Audience} {_jwt.DurationInMinutes} {_jwt.Key}";
    }
}