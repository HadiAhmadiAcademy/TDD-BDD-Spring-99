using System;
using System.Collections.Generic;
using System.Linq;
using FsCheck;

namespace PBTSample.Tests
{
    public class StringGenerator
    {
        public static Arbitrary<string> Generate()
        {
            return Arb.From(from x in Arb.Generate<string>()
                where x != null && x.Length > 8
                select x, Shrink);
        }

        private static IEnumerable<string> Shrink(string arg)
        {
            var characters = arg.ToCharArray();
            if (characters.Length == 1) yield break;;

            for (int i = 0; i < arg.Length; i++)
            {
                var shrinkedArgument = new string(characters.Where((a, b) => b != i).ToArray());
                yield return shrinkedArgument;
            }
        }
    }
}