using Domain.Entities;

namespace Application
{
    public interface IService
    {
        Task<List<User>> GetUsers();
    }
}
