using System.Collections.Generic;
using System.Threading.Tasks;
using TeamBackend.Models;

namespace TeamBackend.Services
{
    public interface IUserService
    {
        Task<List<UserData>> GetAll();

        Task<bool> Delete(int id);

        Task<bool> Create(UserData user);

    }
}