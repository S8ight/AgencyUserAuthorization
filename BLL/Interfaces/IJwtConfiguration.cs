using DAL.Entities;

namespace BLL.Interfaces;

public interface IJwtConfiguration
{
    public string GenerateJwtToken(User user);
    public int? ValidateJwtToken(string token);
    public RefreshToken GenerateRefreshToken(string ipAddress);
}