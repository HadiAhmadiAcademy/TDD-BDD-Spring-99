using FluentAssertions;
using UOM.Domain.Model.UnitOfMeasures;
using UOM.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class ScaledUnitOfMeasureTests
    {
        private readonly BaseUnitOfMeasure _gram;
        public ScaledUnitOfMeasureTests()       //TestClass Instantiate per test method !
        {
            this._gram = BaseUnitOfMeasureFactory.CreateGram();
        }

        [Fact]
        public void scaled_unit_of_measure_constructed_properly()
        {
            var kilogram = new ScaledUnitOfMeasure(2, "Kilogram", "KG", 1000, _gram);

            kilogram.Id.Should().Be(2);
            kilogram.Name.Should().Be("Kilogram");
            kilogram.Symbol.Should().Be("KG");
            kilogram.ConversionRate.Should().Be(1000);
            kilogram.BaseUnitOfMeasureId.Should().Be(_gram.Id);
        }

        [Fact]
        public void scaled_unit_of_measure_converts_to_base_when_its_on_higher_scale()
        {
            var kilogram = new ScaledUnitOfMeasure(2, "Kilogram", "KG", 1000, _gram);

            var amountInBase = kilogram.ConvertToBase(3);

            amountInBase.Should().Be(3000);
        }

        [Fact]
        public void scaled_unit_of_measure_converts_to_base_when_its_on_smaller_scale()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "MG", 0.001M, _gram);

            var amountInBase = milligram.ConvertToBase(3);

            amountInBase.Should().Be(0.003M);
        }

        [Fact]
        public void scaled_unit_of_measures_converts_to_bigger_scaled_unit_of_measure()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "MG", 0.001M, _gram);
            var kilogram = new ScaledUnitOfMeasure(3, "Kilogram", "KG", 1000, _gram);

            var amountInKg = milligram.ConvertTo(kilogram, 2000);

            amountInKg.Should().Be(0.002M);
        }

        [Fact]
        public void scaled_unit_of_measures_converts_to_smaller_scaled_unit_of_measure()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "MG", 0.001M, _gram);
            var kilogram = new ScaledUnitOfMeasure(3, "Kilogram", "KG", 1000, _gram);

            var amountInMg = kilogram.ConvertTo(milligram, 2);

            amountInMg.Should().Be(2000000);
        }
    }
}