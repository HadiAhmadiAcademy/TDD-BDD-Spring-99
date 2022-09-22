using System;
using SharedContext.Fixtures;
using Xunit;

namespace SharedContext
{
    [Collection("Geo")]
    public class UnitTest3 
    {
        private readonly GeographyContext _geographyContext;
        public UnitTest3(GeographyContext geographyContext)
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
