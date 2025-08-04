using System.Collections.Generic;
using System.Threading.Tasks;
using TeamBackend.Models;

namespace TeamBackend.Repositories
{
    public interface IUserRepository
    {

        // New methods
        Task<List<UserData>> GetAll();        // for Get
        Task<bool> Delete(int id);            // for Delete

        Task<bool> Create(UserData user);

    }
}
