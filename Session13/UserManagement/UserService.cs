using System;

namespace UserManagement
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void Register(RegisterUserCommand command)
        {
            var user = new User(command.Username, command.Password);
            _repository.Save(user);
        }
    }
}
