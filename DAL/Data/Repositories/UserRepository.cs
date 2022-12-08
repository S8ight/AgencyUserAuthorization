using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data.Repositories;

public class UserRepository : IUserRepository
{
    protected readonly AgencyContext databaseContext;
    
    protected readonly DbSet<User> user;

    public UserRepository(AgencyContext _context)
    {
        databaseContext = _context;
        user = databaseContext.Set<User>();
    }
    
    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await user.ToListAsync();
    }
    
    public async Task<User> GetUserById(string id)
    {
        return await user.FindAsync(id)
               ?? throw new Exception(
                   $"User with id {id} not found");
    }
    
    public User GetUserByRefreshToken(string token)
    {
        return user.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token))
               ?? throw new Exception(
                   $"User not found, invalid token");
    }

}