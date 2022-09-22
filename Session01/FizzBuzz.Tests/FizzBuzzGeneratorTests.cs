using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Returns_numbers_when_not_divided_by_3_or_5()
        {
            var result = FizzBuzzGenerator.Generate(1, 2);

            var expected = new List<string> { "1", "2"};

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Puts_fizz_in_output_when_number_is_divided_by_3()
        {
            var result = FizzBuzzGenerator.Generate(1, 3);

            var expected = new List<string> { "1", "2", Constants.Fizz };

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Puts_buzz_in_output_when_number_is_divided_by_5()
        {
            var result = FizzBuzzGenerator.Generate(4, 5);

            var expected = new List<string> { "4", Constants.Buzz };

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Puts_fizzBuzz_in_output_when_numbers_is_divided_by_both_3_and_5()
        {
            var result = FizzBuzzGenerator.Generate(13, 16);

            var expected = new List<string> { "13", "14", Constants.FizzBuzz, "16" };

            result.Should().BeEquivalentTo(expected);
        }
    }
}
