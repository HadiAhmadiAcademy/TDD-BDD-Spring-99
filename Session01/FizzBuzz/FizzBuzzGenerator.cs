using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {

        public static List<string> Generate(int start, int end)
        {
            var output = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    output.Add(Constants.FizzBuzz);
                else if (i % 3 == 0)
                    output.Add(Constants.Fizz);
                else if (i % 5 == 0)
                    output.Add(Constants.Buzz);
                else
                        output.Add(i.ToString());
            }
            return output;
        }
    }
}