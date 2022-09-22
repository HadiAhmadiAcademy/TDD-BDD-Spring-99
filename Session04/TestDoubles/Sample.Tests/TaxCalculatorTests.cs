using FluentAssertions;
using NSubstitute;
using Sample.Taxes;
using Xunit;

namespace Sample.Tests
{
    public class TaxCalculatorTests
    {
        [InlineData(1000000, 9, 910000)]
        [InlineData(1000000, 9.5, 905000)]
        [InlineData(1000000, 0, 1000000)]
        [Theory]
        public void tax_is_subtracted_from_salary(long salary, double taxRate, double expected)
        {
            var repository = Substitute.For<ITaxRepository>();
            repository.GetCurrentTaxRate().Returns(taxRate);
            var service = new TaxService(repository);

            var salaryWithoutTaxes = service.CalculateSalary(salary);

            salaryWithoutTaxes.Should().Be(expected);
        }
    }
}