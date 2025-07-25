using System.Threading.Tasks;
using TeamBackend.Models;
using TeamBackend.Repositories;

namespace TeamBackend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Create(UserData user)
        {
            return await _userRepository.Create(user);
        }
        public async Task<bool> Update(UserData user)
        {
            return await _userRepository.Update(user);
        }
    }
}
