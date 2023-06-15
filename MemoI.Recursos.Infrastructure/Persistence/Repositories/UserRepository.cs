using MemoI.Recursos.Application.Contracts.Repositories;
using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    protected readonly RecursosDbContext _context;
        
    public UserRepository(RecursosDbContext context)
    {
        _context = context;
    }
    
    public async Task Add(User user)
    { 
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteAll()
    {
        var users = _context.Users;
        _context.RemoveRange(users);
        await _context.SaveChangesAsync();
    }

    public async Task AddRange(List<User> users)
    {
        await _context.Users.AddRangeAsync(users);
        await _context.SaveChangesAsync();
    }
}