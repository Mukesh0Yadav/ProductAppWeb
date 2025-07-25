using System.Threading.Tasks;
using TeamBackend.Models;

namespace TeamBackend.Repositories
{
    public interface IUserRepository
    {
        Task<bool> Create(UserData user);
        Task<bool> Update(UserData user);
    }
}
