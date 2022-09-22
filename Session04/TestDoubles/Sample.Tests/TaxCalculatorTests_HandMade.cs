using System;
using FluentAssertions;
using Sample.Taxes;
using Sample.Tests.TestDoubles;
using Xunit;

namespace Sample.Tests
{
    public class TaxCalculatorTests_HandMade
    {
        [InlineData(1000000, 9, 910000)]
        [InlineData(1000000, 9.5, 905000)]
        [InlineData(1000000, 0, 1000000)]
        [Theory]
        public void tax_is_subtracted_from_salary(long salary, double taxRate, double expected)
        {
            var repository = StubTaxRepository.CreateNewStub().WhichReturnsTaxRateAs(taxRate); 
            var service = new TaxService(repository);

            var salaryWithoutTaxes = service.CalculateSalary(salary);

            salaryWithoutTaxes.Should().Be(expected);
        }
    }
}
