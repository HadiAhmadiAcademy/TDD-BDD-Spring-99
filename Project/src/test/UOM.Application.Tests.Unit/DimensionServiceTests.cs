using System;
using FluentAssertions;
using NSubstitute;
using PAP.NSubstitute.FluentAssertionsBridge;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Application.Tests.Unit
{
    public class DimensionServiceTests
    {
        [Fact]
        public void saves_a_dimension_into_database()
        {
            //TODO: discuss using mocks vs stubs here
            //TODO: discuss the value of unit test vs integration tests in orchestrations
            var repository = Substitute.For<IDimensionRepository>();
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto()
            {
                Name = "Mass",
                Symbol = "m"
            };
            var expected = new Dimension("Mass","m");

            service.DefineDimension(dto);

            repository.Received(1).Add(Verify.That<Dimension>(a=> a.Should().BeEquivalentTo(expected)));
        }
    }
}
