using FluentAssertions;
using Xunit;

namespace UserManagement.Tests
{
    public class UserServiceTests_SelfShunt : IUserRepository
    {
        private User _savedUser;
        private int _numberOfSavedUsers;
        [Fact]
        public void saves_user_on_registration()
        {
            var service = new UserService(this);

            service.Register(new RegisterUserCommand(){ Username = "admin", Password = "123456"});

            _numberOfSavedUsers.Should().Be(1);
            _savedUser.Username.Should().Be("admin");
            _savedUser.Password.Should().Be("123456");
        }

        public void Save(User user)
        {
            this._savedUser = user;
            _numberOfSavedUsers++;
        }
    }
}