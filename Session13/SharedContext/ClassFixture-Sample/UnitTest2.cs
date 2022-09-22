using SharedContext.Fixtures;
using Xunit;

namespace SharedContext
{
    public class UnitTest2 : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _fixture;
        public UnitTest2(DatabaseFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}