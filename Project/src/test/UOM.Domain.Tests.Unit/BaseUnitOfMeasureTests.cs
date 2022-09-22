using FluentAssertions;
using UOM.Domain.Model.UnitOfMeasures;
using UOM.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class BaseUnitOfMeasureTests
    {
        [Fact]
        public void base_unit_of_measure_is_defined_in_a_dimension()
        {
            var mass = DimensionFactory.CreateMassDimension();

            var gram = new BaseUnitOfMeasure(1, "Gram", "gr", mass);

            gram.Id.Should().Be(1);
            gram.Dimension.Should().Be(mass.Id);
            gram.Name.Should().Be("Gram");
            gram.Symbol.Should().Be("gr");
        }
    }
}
