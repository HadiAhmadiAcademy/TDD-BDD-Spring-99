using System;
using SharedContext.Fixtures;
using Xunit;

namespace SharedContext
{
    [Collection("Geo")]
    public class UnitTest4 
    {
        private readonly GeographyContext _geographyContext;
        public UnitTest4(GeographyContext geographyContext)
        {
            _geographyContext = geographyContext;
        }

        [Fact]
        public void Test1()
        {
            var x = _geographyContext.RandomId;
        }
        [Fact]
        public void Test2()
        {
            var x = _geographyContext.RandomId;
        }
    }
}
