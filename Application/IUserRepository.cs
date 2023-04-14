using Domain.Entities;

namespace Application
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
    }
}
