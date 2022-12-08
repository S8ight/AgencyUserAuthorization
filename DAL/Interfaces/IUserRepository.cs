using DAL.Entities;

namespace DAL.Interfaces;

public interface IUserRepository
{
    public Task<IEnumerable<User>> GetAllUsers();
    public Task<User> GetUserById(string id);
    public User GetUserByRefreshToken(string token);
}