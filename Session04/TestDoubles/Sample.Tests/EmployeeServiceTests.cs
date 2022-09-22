using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NSubstitute;
using PAP.NSubstitute.FluentAssertionsBridge;
using Sample.Employees;
using Sample.Tests.TestDoubles;
using Xunit;

namespace Sample.Tests
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void saves_employee_on_registration()
        {
            var mockRepository = Substitute.For<IEmployeeRepository>();
            var service = new EmployeeService(mockRepository, new DummyLogger());
            var expected = new Employee() { Firstname = "john", Lastname = "doe" };   

            service.RegisterEmployee("john", "doe");

            mockRepository.Received(1).Create(Verify.That<Employee>(a=> a.Should().BeEquivalentTo(expected)));
        }
    }
}
