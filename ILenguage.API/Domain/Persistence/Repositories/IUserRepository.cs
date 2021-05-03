using System.Collections.Generic;
using System.Threading.Tasks;
using ILenguage.API.Domain.Models;

namespace ILenguage.API.Domain.Persistence.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task<IEnumerable<User>> ListByUserIdAsync(int userId);
        Task AddAsync(User user);
        Task<User> FindById(int userId);
        Task Update(User user);
        Task Remove(User user);

    }
}