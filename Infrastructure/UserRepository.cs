using Application;
using Domain.Entities;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly HandymanDbContext _context;

        public UserRepository(HandymanDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }
    }
}
