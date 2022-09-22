using System;
using FsCheck;
using FsCheck.Xunit;

namespace PBTSample.Tests
{
    public class CalculatorTests
    {
        [Property]
        public Property adding_number_with_self_results_in_multiply_it_by_two(int x)
        {
            return (Calculator.Add(x, x) == x * 2)
                .ToProperty()
                .Classify(x > 0, "above zero")
                .Classify(x < 0, "below zero")
                .Classify(x == 0, "zero");
        }

        [Property]
        public Property subtracting_first_number_from_sum_results_in_second_number(int x, int y)
        {
            return (Calculator.Add(x, y) - y == x).ToProperty();
        }

        [Property]
        public Property dividing_number_with_self_results_number_itself(int x)
        {
            return (Calculator.Division(x, 1) == x).ToProperty();
        }

        [Property]
        public Property divide_multiply_number_with_something_results_in_number_itself(int x, int y)
        {
            Func<bool> division = () => Calculator.Division(x * y, y) == x;     //Lazy
            return division.When(y != 0);
        }

        [Property]
        public Property testing_custom_generator()
        {
            return Prop.ForAll(EvenNumberGenerator.Generate(), x =>
                (Calculator.Add(x, x) == x * 2).ToProperty()
            );
        }
    }
}
