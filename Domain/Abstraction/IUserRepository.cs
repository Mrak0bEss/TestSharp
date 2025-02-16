using Domain.Entities;

namespace Domain.Abstraction
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid id);
        Task AddAsync(User user);
    }
}
