using FluentAssertions;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class DimensionTests
    {
        [Fact]
        public void dimension_constructed_properly()
        {
            var measurement = new Dimension("Mass", "m");

            measurement.Name.Should().Be("Mass");
            measurement.Symbol.Should().Be("m");
        }
    }
}