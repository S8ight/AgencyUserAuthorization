using BLL.DTO.Request;
using BLL.DTO.Response;
using DAL.Entities;

namespace BLL.Interfaces;

public interface IUserService
{
    AuthenticationResponse Authenticate(AuthenticationRequest model, string ipAddress);
    public Task<string> Register(RegistrationRequest model, string ipAddress);
    AuthenticationResponse RefreshToken(string token, string ipAddress);
    void RevokeToken(string token, string ipAddress);
    public Task<IEnumerable<User>> GetAll();
    Task<User> GetById(string id);
    public Task<string> VerifyEmail(string token, string email);
    public Task AddUserToQueue(string email);
}