namespace DefaultNamespace;

public interface IJwtTokenService
{
    string GenerateToken(Usuario user);
}
