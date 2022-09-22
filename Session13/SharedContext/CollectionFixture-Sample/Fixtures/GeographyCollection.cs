using System.Collections.Generic;
using Xunit;

namespace SharedContext.Fixtures
{
    [CollectionDefinition("Geo")]
    public class GeographyCollection : ICollectionFixture<GeographyContext>
    { }
}