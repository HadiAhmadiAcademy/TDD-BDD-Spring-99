using System;
using FluentAssertions;
using UserManagement.Tests.TestDoubles;
using Xunit;

namespace UserManagement.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void saves_user_on_registration()
        {
            var repository = new UserRepositorySpy();
            var service = new UserService(repository);
            
            service.Register(new RegisterUserCommand(){ Username = "admin", Password = "123456"});

            repository.GetNumberOfSavedUsers.Should().Be(1);
            repository.GetSavedUser().Username.Should().Be("admin");        //we can use expected-object instead
            repository.GetSavedUser().Password.Should().Be("123456");
        }
    }
}
