using Domain.Entities;

namespace Application
{
    public class Service : IService
    {
        private readonly IUserRepository _userRepository;

        public Service(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }
    }
}
