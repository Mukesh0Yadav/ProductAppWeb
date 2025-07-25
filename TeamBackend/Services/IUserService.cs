using System.Threading.Tasks;
using TeamBackend.Models;

namespace TeamBackend.Services
{
    public interface IUserService
    {
        Task<bool> Create(UserData user);
        Task<bool> Update(UserData user);
    }
}
