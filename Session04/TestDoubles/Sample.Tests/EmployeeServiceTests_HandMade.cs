using FluentAssertions;
using Sample.Employees;
using Sample.Tests.TestDoubles;
using Xunit;

namespace Sample.Tests
{
    public class EmployeeServiceTests_HandMade
    {
        [Fact]
        public void saves_employee_on_registration()
        {
            var mockRepository = new HandMadeMockEmployeeRepository();
            var service = new EmployeeService(mockRepository, new DummyLogger());
            var expected = new Employee() { Firstname = "john", Lastname = "doe"};

            service.RegisterEmployee("john","doe");

            mockRepository.GetCalled(nameof(IEmployeeRepository.Create)).CalledTimes.Should().Be(1);
            mockRepository.GetCalled(nameof(IEmployeeRepository.Create)).PassedArgument.Should().BeEquivalentTo(expected);
        }
    }
}