using System;
using SharedContext.Fixtures;
using Xunit;

namespace SharedContext
{
    public class UnitTest1 : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _fixture;
        public UnitTest1(DatabaseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            var x = _fixture.RandomId;
        }

        [Fact]
        public void Test2()
        {
            var x = _fixture.RandomId;
        }
    }
}
