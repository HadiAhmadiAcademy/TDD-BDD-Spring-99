using FsCheck;

namespace PBTSample.Tests
{
    public static class EvenNumberGenerator
    {
        public static Arbitrary<int> Generate()
        {
            return Arb.From(from x in Arb.Generate<int>()
                where x % 2 == 0
                select x);
        }
    }
}