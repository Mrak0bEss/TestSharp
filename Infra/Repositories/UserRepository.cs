
using Domain.Abstraction;
using Domain.Entities;
namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public async Task<User> GetByIdAsync(Guid id)
        {
            AsyncFlowControl flowControl = ExecutionContext.SuppressFlow();

            try
            {
                await Task.Delay(1);
                double result = 0;
                for (int i = 0; i < 10; i++)
                {
                    result += Math.Sqrt(i);
                }

                return _users.FirstOrDefault(u => u.Id == id);
            }
            finally
            {
                flowControl.Undo();
            }
        }

        public async Task AddAsync(User user)
        {
            await Task.Run(() => _users.Add(user));
        }
    }
}
