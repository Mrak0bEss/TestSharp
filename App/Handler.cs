using Domain.Abstraction;
using Domain.Entities;
namespace App
{
    public class Handler
    {
        public class NewUserRequest()
        {
            public string Data { get; set; }
        }
        private readonly IUserRepository _userRepository;

        public Handler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(NewUserRequest newUser)
        {
            var user = new User(newUser.Data);
            await _userRepository.AddAsync(user);
            return user.Id;
        }
    }
}
